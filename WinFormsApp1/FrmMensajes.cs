using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using static UI.FrmMenu;

namespace UI
{
    public partial class FrmMensajes : Formulario
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;
        private TipoUsuario UsuarioActual;
        private string emisor;
        private string pathArchivoMensajesEmisor;
        private List<Usuario> listaContactos = new List<Usuario>();
        private Usuario contactoSeleccionado;

        // Delegado para actualizar el RichTextBox
        private delegate void ActualizarRichTextBoxDelegado(string mensaje, HorizontalAlignment alineacion);

        // Acceder a la instancia de MensajeManager
        private MensajeManager mensajeManager = MensajeManager.Instancia;

        public FrmMensajes()
        {
            InitializeComponent();
        }

        private void FrmMensajes_Load(object sender, EventArgs e)
        {
            string pathAdministradores = "registrosAdministrador.json";
            string pathInquilinos = "registrosInquilino.json";

            if (File.Exists(pathInquilinos))
            {
                List<Inquilino> listaVecinos = Serializadora<Inquilino>.CargarDesdeJSON(pathInquilinos);

                if (File.Exists(pathAdministradores))
                {
                    List<Administrador> listaAdministradores = Serializadora<Administrador>.CargarDesdeJSON(pathAdministradores);

                    foreach (var administrador in listaAdministradores)
                    {
                        foreach (var inquilino in listaVecinos)
                        {
                            if (administrador.Identificacion == inquilino.Vivienda.identificacionArriendador)
                            {
                                if (inquilinoActual != null)
                                {
                                    if (inquilinoActual.Dni != inquilino.Dni)
                                    {
                                        listaContactos.Add(inquilino);
                                    }

                                    if (!listaContactos.Contains(administrador) && UsuarioActual == TipoUsuario.Inquilino)
                                    {
                                        listaContactos.Add(administrador);
                                    }
                                }
                                else
                                {
                                    listaContactos.Add(inquilino);

                                    if (!listaContactos.Contains(administrador) && UsuarioActual == TipoUsuario.Inquilino)
                                    {
                                        listaContactos.Add(administrador);
                                    }
                                }
                            }
                        }
                    }
                }

                lstContactos.DataSource = listaContactos;
                this.contactoSeleccionado = (Usuario)lstContactos.SelectedItem;
                lstContactos.SelectedIndexChanged += lstContactos_SelectedIndexChanged;
            }
        }

        private async void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rtbChat.Visible = true;
            this.btnEnviar.Visible = true;
            this.txtMensaje.Visible = true;
            this.contactoSeleccionado = (Usuario)lstContactos.SelectedItem;

            await CargarMensajesAsync();

            List<Mensaje> mensajesEnviados = mensajeManager.ObtenerMensajesEmisor()
                .Where(m => m.Emisor == emisor && m.Receptor == contactoSeleccionado.ToString())
                .ToList();

            List<Mensaje> mensajesRecibidos = mensajeManager.ObtenerMensajesReceptor()
                .Where(m => m.Emisor == contactoSeleccionado.ToString() && m.Receptor == emisor)
                .ToList();

            MostrarMensajesEnChat(mensajesRecibidos, mensajesEnviados);
        }

        private async Task CargarMensajesAsync()
        {
            if (File.Exists(pathArchivoMensajesEmisor))
            {
                List<Mensaje> mensajesCargados = await Task.Run(() => Serializadora<Mensaje>.CargarDesdeJSON(pathArchivoMensajesEmisor));

                // Filtrar solo los mensajes nuevos desde la última carga
                List<Mensaje> mensajesNuevos = mensajesCargados
                    .Where(m => !mensajeManager.ObtenerMensajesEmisor().Any(em => em.Equals(m)))
                    .ToList();

                if (mensajesNuevos.Any())
                {
                    mensajeManager.ObtenerMensajesEmisor().AddRange(mensajesNuevos);

                    // Actualizar mensajes del receptor
                    await ActualizarMensajesReceptorAsync();

                    List<Mensaje> mensajesEnviados = mensajeManager.ObtenerMensajesEmisor()
                        .Where(m => m.Emisor == emisor && m.Receptor == contactoSeleccionado.ToString())
                        .ToList();

                    List<Mensaje> mensajesRecibidos = mensajeManager.ObtenerMensajesReceptor()
                        .Where(m => m.Emisor == contactoSeleccionado.ToString() && m.Receptor == emisor)
                        .ToList();

                    MostrarMensajesEnChat(mensajesRecibidos, mensajesEnviados);
                }
            }
        }

        private async Task ActualizarMensajesReceptorAsync()
        {
            if (File.Exists($"mensajes{emisor}.json"))
            {
                List<Mensaje> mensajesCargados = await Task.Run(() => Serializadora<Mensaje>.CargarDesdeJSON($"mensajes{emisor}.json"));

                // Filtrar solo los mensajes nuevos desde la última carga
                List<Mensaje> mensajesNuevos = mensajesCargados
                    .Where(m => !mensajeManager.ObtenerMensajesReceptor().Any(em => em.Equals(m)))
                    .ToList();

                if (mensajesNuevos.Any())
                {
                    mensajeManager.ObtenerMensajesReceptor().AddRange(mensajesNuevos);
                }
            }
        }

        private void MostrarMensajesEnChat(List<Mensaje> mensajesRecibidos, List<Mensaje> mensajesEnviados)
        {
            rtbChat.Clear();

            // Concatenar todos los mensajes en una lista única
            var todosLosMensajes = mensajesRecibidos.Concat(mensajesEnviados).ToList();

            // Ordenar la lista por fecha
            todosLosMensajes.Sort((m1, m2) => m1.FechaEnvio.CompareTo(m2.FechaEnvio));

            // Mostrar los mensajes ordenados en el RichTextBox
            HashSet<string> mensajesMostrados = new HashSet<string>();

            foreach (Mensaje mensaje in todosLosMensajes)
            {
                string mensajeFormateado = $"{mensaje.FechaEnvio.ToString("HH:mm:ss")} - {mensaje.Emisor}: {mensaje.Contenido}\n";

                // Verificar si el mensaje ya se mostró para evitar duplicados
                if (mensajesMostrados.Add(mensajeFormateado))
                {
                    AgregarMensajeRichTextBox(mensajeFormateado, mensaje.Emisor == emisor ? HorizontalAlignment.Right : HorizontalAlignment.Left);
                }
            }

            rtbChat.SelectionStart = rtbChat.Text.Length;
            rtbChat.ScrollToCaret();
        }




        private void AgregarMensajeRichTextBox(string mensaje, HorizontalAlignment alineacion)
        {
            rtbChat.SelectionAlignment = alineacion;
            rtbChat.AppendText(mensaje);
            rtbChat.ScrollToCaret();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string contenido = txtMensaje.Text;

            await EnviarMensajeAsync(contenido);

            txtMensaje.Clear();
        }

        private async Task EnviarMensajeAsync(string contenido)
        {
            if (contactoSeleccionado != null)
            {
                Mensaje nuevoMensaje = new Mensaje(contenido, emisor, this.contactoSeleccionado.ToString());
                string pathMensajesReceptor = "mensajes" + contactoSeleccionado.ToString() + ".json";

                await Task.Run(() =>
                {
                    // Verificar si el mensaje ya existe en la lista
                    if (!mensajeManager.ObtenerMensajesReceptor().Any(m => m.Equals(nuevoMensaje)))
                    {
                        mensajeManager.GuardarMensajeReceptor(nuevoMensaje);
                        Serializadora<Mensaje>.GuardarComoJSON(mensajeManager.ObtenerMensajesReceptor(), pathMensajesReceptor);

                        mensajeManager.GuardarMensajeEmisor(nuevoMensaje);
                        Serializadora<Mensaje>.GuardarComoJSON(mensajeManager.ObtenerMensajesEmisor(), pathArchivoMensajesEmisor);
                    }
                });

                await CargarMensajesAsync();

                List<Mensaje> mensajesEnviados = mensajeManager.ObtenerMensajesEmisor()
                    .Where(m => m.Emisor == emisor && m.Receptor == contactoSeleccionado.ToString())
                    .ToList();

                List<Mensaje> mensajesRecibidos = mensajeManager.ObtenerMensajesReceptor()
                    .Where(m => m.Emisor == contactoSeleccionado.ToString() && m.Receptor == emisor)
                    .ToList();

                MostrarMensajesEnChat(mensajesRecibidos, mensajesEnviados);
            }
        }

        public void SetAdministrador(Administrador administrador)
        {
            this.administradorActual = administrador;
            UsuarioActual = TipoUsuario.Administrador;
            emisor = administradorActual.ToString();
            pathArchivoMensajesEmisor = "mensajes" + administradorActual.ToString() + ".json";
        }

        public void SetInquilino(Inquilino inquilino)
        {
            this.inquilinoActual = inquilino;
            UsuarioActual = TipoUsuario.Inquilino;
            emisor = inquilinoActual.ToString();
            pathArchivoMensajesEmisor = "mensajes" + inquilinoActual.ToString() + ".json";
        }

        private void FrmMensajes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializadora<Mensaje>.GuardarComoJSON(mensajeManager.ObtenerMensajesEmisor(), pathArchivoMensajesEmisor);

            if (contactoSeleccionado != null)
            {
                string pathMensajesReceptor = "mensajes" + contactoSeleccionado.ToString() + ".json";
                mensajeManager.ObtenerMensajesReceptor().AddRange(mensajeManager.ObtenerMensajesEmisor().Where(m => m.Receptor == contactoSeleccionado.ToString()));
                Serializadora<Mensaje>.GuardarComoJSON(mensajeManager.ObtenerMensajesReceptor(), pathMensajesReceptor);
            }
        }
    }
}

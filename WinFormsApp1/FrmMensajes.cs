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
        private OperacionesBDMensajes<Mensaje> baseDatosMensajesEmisor;
        private OperacionesBDMensajes<Mensaje> baseDatosMensajesReceptor;
        private OperacionesBDAdministrador<Administrador> baseDatosAdministradores;
        private OperacionesBDInquilino<Inquilino> baseDatosInquilinos;
        private List<Usuario> listaContactos = new List<Usuario>();
        private Usuario contactoSeleccionado;
        private string cadenaConexion;

        // Delegado para actualizar el RichTextBox
        private delegate void ActualizarRichTextBoxDelegado(string mensaje, HorizontalAlignment alineacion);


        private MensajeManager mensajeManager = MensajeManager.Instancia;

        public FrmMensajes()
        {
            InitializeComponent();
            InitializeComponent();
            cadenaConexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=nestapp;UID=root;PASSWORDS=;";
            baseDatosAdministradores = new OperacionesBDAdministrador<Administrador>(cadenaConexion);
            baseDatosInquilinos = new OperacionesBDInquilino<Inquilino>(cadenaConexion);
            if (UsuarioActual == TipoUsuario.Inquilino)
            {
                baseDatosMensajesEmisor = new OperacionesBDMensajes<Mensaje>(cadenaConexion, inquilinoActual);
            }
            else
            {
                baseDatosMensajesEmisor = new OperacionesBDMensajes<Mensaje>(cadenaConexion, administradorActual);
            }
            
        }

        private void FrmMensajes_Load(object sender, EventArgs e)
        {
            // Obtener listas de administradores y vecinos desde otras fuentes
            
            List<Inquilino> listaVecinos = ObtenerVecinosDesdeOtraFuente(baseDatosInquilinos.ObtenerTodos());

            
            
            listaContactos.AddRange(listaVecinos);
            if (UsuarioActual == TipoUsuario.Inquilino)
            { 
                Administrador administrador = ObtenerAdminDesdeOtraFuente(baseDatosAdministradores.ObtenerTodos());
                listaContactos.Add(administrador);
            }
            
            lstContactos.DataSource = listaContactos;
            this.contactoSeleccionado = (Usuario)lstContactos.SelectedItem;
            lstContactos.SelectedIndexChanged += lstContactos_SelectedIndexChanged;
        }
        private Administrador ObtenerAdminDesdeOtraFuente(List<Administrador> listaAdministradores)
        {
            Administrador administradorACargo = null;
            foreach (var administrador in listaAdministradores)
            {
                if (inquilinoActual.Vivienda.identificacionArriendador == administrador.Identificacion)
                {
                    administradorACargo = administrador;
                    return administradorACargo;
                }
            }
            return administradorACargo;
        }
        private List<Inquilino> ObtenerVecinosDesdeOtraFuente(List<Inquilino>listaInquilinos)
        {
            List<Inquilino> listaVecinos = new List<Inquilino>();
            foreach (var inquilino in listaInquilinos)
            {
                if (inquilino.Vivienda == null)
                {
                    OperacionesBDVivienda<Vivienda> baseDatosViviendas = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
                    List<Vivienda> listaViviendas = baseDatosViviendas.ObtenerTodos();
                    foreach (var vivienda in listaViviendas)
                    {
                        if (vivienda.DniInquilino == inquilino.Dni)
                        {
                            inquilino.Vivienda = vivienda;
                        }
                    }
                }
                if (inquilinoActual.Vivienda == null)
                {
                    OperacionesBDVivienda<Vivienda> baseDatosViviendas = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
                    List<Vivienda> listaViviendas = baseDatosViviendas.ObtenerTodos();
                    foreach (var vivienda in listaViviendas)
                    {
                        if (vivienda.DniInquilino == inquilinoActual.Dni)
                        {
                            inquilinoActual.Vivienda = vivienda;
                        }
                    }
                }
                if (inquilino.Vivienda.identificacionArriendador == inquilinoActual.Vivienda.identificacionArriendador && inquilinoActual.Dni != inquilino.Dni)
                {
                    listaVecinos.Add(inquilino);
                }
            }
            return listaVecinos;
            
        }
        private async void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rtbChat.Visible = true;
            this.btnEnviar.Visible = true;
            this.txtMensaje.Visible = true;
            this.contactoSeleccionado = (Usuario)lstContactos.SelectedItem;
            baseDatosMensajesEmisor = new OperacionesBDMensajes<Mensaje>(cadenaConexion, contactoSeleccionado);
            this.lblInquilino.Text = contactoSeleccionado.ToString();
            await CargarMensajesAsync();

            List<Mensaje> mensajesEnviados = mensajeManager.ObtenerMensajesEmisor()
                .Where(m => m.Emisor == emisor && m.Receptor == contactoSeleccionado.ToString())
                .ToList();

            List<Mensaje> mensajesRecibidos = mensajeManager.ObtenerMensajesEmisor()
                .Where(m => m.Emisor == contactoSeleccionado.ToString() && m.Receptor == emisor)
                .ToList();

            MostrarMensajesEnChat(mensajesRecibidos, mensajesEnviados);
        }

        private async Task CargarMensajesAsync()
        {
            try
            {
                List<Mensaje> mensajesCargados = await Task.Run(() => baseDatosMensajesEmisor.ObtenerTodos(emisor));

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
            catch (Exception ex)
            {   
                //MostrarError($"Error al cargar mensajes: {ex}"); 
            }
            
        }

        private async Task ActualizarMensajesReceptorAsync()
        {
            try
            {
                List<Mensaje> mensajesCargados = await Task.Run(() => baseDatosMensajesReceptor.ObtenerTodos(emisor));
                
                List<Mensaje> mensajesNuevos = mensajesCargados
                    .Where(m => !mensajeManager.ObtenerMensajesReceptor().Any(em => em.Equals(m)))
                    .ToList();

                if (mensajesNuevos.Any())
                {
                    mensajeManager.ObtenerMensajesReceptor().AddRange(mensajesNuevos);
                }
            }
            catch (Exception ex)
            {
               string mensajeError =  $"Error al cargar mensajes: {ex}";
                
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



        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}");
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
                Mensaje nuevoMensaje = new Mensaje(contenido, emisor, this.contactoSeleccionado.ToString(), DateTime.Now);
                

                await Task.Run(() =>
                {
                    // Verificar si el mensaje ya existe en la lista
                    if (!mensajeManager.ObtenerMensajesReceptor().Any(m => m.Equals(nuevoMensaje)))
                    {
                        baseDatosMensajesEmisor.Insertar(nuevoMensaje);
                        
                    }
                });

                await CargarMensajesAsync();

                List<Mensaje> mensajesEnviados = mensajeManager.ObtenerMensajesEmisor()
                    .Where(m => m.Emisor == emisor && m.Receptor == contactoSeleccionado.ToString())
                    .ToList();

                List<Mensaje> mensajesRecibidos = mensajeManager.ObtenerMensajesEmisor()
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
            
        }

        public void SetInquilino(Inquilino inquilino)
        {
            this.inquilinoActual = inquilino;
            UsuarioActual = TipoUsuario.Inquilino;
            emisor = inquilinoActual.ToString();
            if (inquilinoActual.Vivienda != null)
            {
                OperacionesBDVivienda<Vivienda> baseDatosViviendas = new OperacionesBDVivienda<Vivienda>(cadenaConexion);
                List<Vivienda> listaViviendas = baseDatosViviendas.ObtenerTodos();
                foreach (var vivienda in listaViviendas)
                {
                    if (vivienda.DniInquilino == inquilinoActual.Dni)
                    {
                        inquilinoActual.Vivienda = vivienda;
                    }
                }
            }

        }


        private void btnAtras_Click(object sender, EventArgs e)
        {

            if (UsuarioActual == TipoUsuario.Inquilino)
            {

                this.Hide();
                FrmMenu menuInqui = new FrmMenu();
                menuInqui.SetInquilino(inquilinoActual);
                menuInqui.Show();
            }
            else 
            {
                this.Hide();
                FrmMenu menuAdmin = new FrmMenu();
                menuAdmin.SetAdministrador(administradorActual);
                menuAdmin.Show();
            }
        }
    }
}

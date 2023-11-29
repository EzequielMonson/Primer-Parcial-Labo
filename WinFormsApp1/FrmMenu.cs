using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using NestApp;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FrmMenu : Formulario
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;
        public List<Inquilino> listaInquilinos;
        public Deuda deudaActual;


        public FrmMenu()
        {
            InitializeComponent();
        }
        public void FrmMenu_Load(object sender, EventArgs e)
        {
            string jsonFilePath = "registrosInquilino.json";

            if (File.Exists(jsonFilePath))
            {
                //string jsonContent = File.ReadAllText(jsonFilePath);
                //listaInquilinos = JsonSerializer.Deserialize<List<Inquilino>>(jsonContent);
                listaInquilinos = Serializadora<Inquilino>.CargarDesdeJSON(jsonFilePath);
            }
            else
            {
                MessageBox.Show("El archivo JSON no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaInquilinos = new List<Inquilino>();
            }
            if (UsuarioActual == TipoUsuario.Administrador)
            {
                List<Vivienda> listaVivienda = administradorActual.viviendasACargo;
                List<Inquilino> listaInquilinosDeViviendasACargo = new List<Inquilino>();
                foreach (var vivienda in listaVivienda)
                {
                    foreach (var inquilino in listaInquilinos)
                    {
                        if (vivienda.dniInquilino == inquilino.dni)
                        {
                            listaInquilinosDeViviendasACargo.Add(inquilino);
                            inquilino.CalcularDeuda(vivienda);

                        }
                    }
                }
                Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, jsonFilePath);
                this.cmbInquilinoSeleccionado.DataSource = listaInquilinosDeViviendasACargo;
                this.grpInquilinoSeleccionado.Visible = true;
                cmbInquilinoSeleccionado.DisplayMember = "ToString";
                cmbInquilinoSeleccionado.ValueMember = null;
                //this.grpPagos.Location = grpInquilinoSeleccionado.Location;

                Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
                this.inquilinoActual = inquilinoSeleccionado;

                if (inquilinoSeleccionado != null)
                {
                    // Mostrar el nombre del inquilino en algún control, por ejemplo, un label
                    lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                    lblInquilinoSeleccionado.Location = new Point(70, 19);


                    CargarPagos();
                    CargarDeudas();
                }
                cmbInquilinoSeleccionado.SelectedIndexChanged += cmbInquilinoSeleccionado_SelectedIndexChanged;


            }
            if (UsuarioActual == TipoUsuario.Inquilino)
            {
                CargarPagos();
                CargarDeudas();
            }
        }
        private void cmbInquilinoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpDeudas.Visible = false;
            grpPagos.Visible = false;
            Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
            this.inquilinoActual = inquilinoSeleccionado;
            if (inquilinoSeleccionado != null)
            {
                lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                lblInquilinoSeleccionado.Location = new Point(70, 19);


                //CargarPagos();
                CargarDeudas();
            }
        }
        public enum TipoUsuario
        {
            Administrador,
            Inquilino
        }

        public TipoUsuario UsuarioActual { get; private set; }

        // método para establecer el administrador actual
        public void SetAdministrador(Administrador administrador)
        {

            administradorActual = administrador;
            UsuarioActual = TipoUsuario.Administrador;

        }

        public void SetInquilino(Inquilino inquilino)
        {
            inquilinoActual = inquilino;
            UsuarioActual = TipoUsuario.Inquilino;
            this.grpInquilinoSeleccionado.Visible = false;


        }
        private void CargarPagos()
        {
            // Asumiendo que Inquilino tiene una propiedad List<Pago> llamada Pagos
            List<Pago> listaPagos = inquilinoActual.HistorialPagos;

            dtgPagos.Rows.Clear();
            if (listaPagos != null)
            {
                foreach (var pago in listaPagos)
                {
                    // Añadir una nueva fila y llenar las columnas específicas
                    int rowIndex = dtgPagos.Rows.Add();
                    dtgPagos.Rows[rowIndex].Cells["fechaAbonoPagos"].Value = pago.FechaAbono;
                    dtgPagos.Rows[rowIndex].Cells["cantidadAbonadaPagos"].Value = pago.CantidadAbonada;
                    dtgPagos.Rows[rowIndex].Cells["fechaVencimientoPagos"].Value = pago.FechaVencimiento;
                }
            }
        }
        private void CargarDeudas()
        {
            // Asumiendo que Inquilino tiene una propiedad Queue<Deuda> llamada ColaDeudas

            Queue<Deuda> colaDeudas = inquilinoActual.ColaDeudas;

            dtgDeudas.Rows.Clear();

            foreach (var deuda in colaDeudas)
            {
                // Añadir una nueva fila y llenar las columnas específicas
                int rowIndex = dtgDeudas.Rows.Add();
                dtgDeudas.Rows[rowIndex].Cells["fechaEmisionDeudas"].Value = deuda.FechaEmision;
                dtgDeudas.Rows[rowIndex].Cells["cantidadAbonarDeudas"].Value = deuda.Monto;
                dtgDeudas.Rows[rowIndex].Cells["FechaVencimiento"].Value = deuda.FechaVencimiento;

                // Verificar si el usuario actual es un administrador
                if (UsuarioActual == TipoUsuario.Administrador)
                {
                    // Asumiendo que Administrador tiene una propiedad List<Inquilino> llamada InquilinosDeudores
                    List<Inquilino> inquilinosDeudores = administradorActual.inquilinosDeudores;

                    // Buscar el inquilino asociado a la deuda
                    Inquilino inquilinoDeudor = inquilinosDeudores.FirstOrDefault(i => i.ColaDeudas.Contains(deuda));

                    // Mostrar el nombre del inquilino en la columna "inquilino"
                    dtgDeudas.Rows[rowIndex].Cells["inquilino"].Value = inquilinoDeudor != null ? inquilinoDeudor.nombre : "No disponible";
                }
            }
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (!pnlOpciones.Visible)
            {
                pnlOpciones.Visible = true;
            }
            else
            {
                pnlOpciones.Visible = false;
            }
            if (UsuarioActual != TipoUsuario.Administrador)
            {
                btnIngresarSaldo.Visible = true;
            }
        }

        private void btnMostrarDeudas_Click(object sender, EventArgs e)
        {
            if (grpPagos.Visible || !grpDeudas.Visible)
            {
                grpDeudas.Visible = true;
                grpPagos.Visible = false;
                CargarDeudas();

            }
        }

        private void btnMostrarPagos_Click(object sender, EventArgs e)
        {
            if (grpDeudas.Visible || !grpPagos.Visible)
            {
                grpPagos.Visible = true;
                grpPagos.Location = grpDeudas.Location;
                grpDeudas.Visible = false;
                CargarPagos();

            }
        }



        private void dtgDeudas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsuarioActual != TipoUsuario.Administrador)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dtgDeudas.Rows[e.RowIndex];
                    if (selectedRow.Cells["fechaEmisionDeudas"].Value != null)
                    {
                        DateTime fechaEmisionSeleccionada = (DateTime)selectedRow.Cells["fechaEmisionDeudas"].Value;
                        Deuda deudaSeleccionada = ObtenerDeudaPorFecha(fechaEmisionSeleccionada);


                        if (deudaSeleccionada != null)
                        {
                            btnPagarDeudaSeleccionada.Visible = true;
                            this.deudaActual = deudaSeleccionada;

                        }

                    }
                }
            }
        }

        private Deuda ObtenerDeudaPorFecha(DateTime fechaEmisionSeleccionada)
        {
            foreach (Deuda deuda in inquilinoActual.ColaDeudas)
            {
                if (deuda.FechaEmision == fechaEmisionSeleccionada)
                {
                    return deuda; // Se encontró la deuda con la fecha de emisión dada
                }
            }

            return null; // No se encontró ninguna deuda con la fecha de emisión dada
        }

        private void btnPagarDeudaSeleccionada_Click(object sender, EventArgs e)
        {
            if (deudaActual != null)
            {
                DialogResult resultado = MessageBox.Show($"¿Deseas pagar la deuda seleccionada con monto: {deudaActual.Monto}?",
                                                          "Confirmar Pago",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el saldo del inquilino


                    foreach (var inquilino in listaInquilinos)
                    {
                        if (inquilino.dni == inquilinoActual.dni)
                        {
                            Pago nuevoPago = new Pago(deudaActual.Monto, deudaActual.FechaVencimiento);
                            inquilino.historialPagos.Add(nuevoPago);
                            inquilino.saldo -= deudaActual.Monto;
                            inquilino.ColaDeudas.Dequeue();
                            inquilinoActual = inquilino;
                            break;
                        }
                    }
                    // Guardar la lista actualizada en el archivo JSON
                    string jsonFilePath = "registrosInquilino.json";
                    Serializadora<Inquilino>.GuardarComoJSON(listaInquilinos, jsonFilePath);
                    
                    CargarPagos();
                    CargarDeudas();
                }
                else
                {
                    // El usuario eligió no pagar la deuda, puedes realizar acciones adicionales si es necesario
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }

        private void btnIngresarSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}

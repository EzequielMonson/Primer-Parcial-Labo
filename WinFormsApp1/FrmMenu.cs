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

namespace UI
{
    public partial class FrmMenu : Formulario
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;
        public List<Inquilino> listaInquilinos;

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
                listaInquilinos = new List<Inquilino> ();
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
                cmbInquilinoSeleccionado.ValueMember =  null;
                //this.grpPagos.Location = grpInquilinoSeleccionado.Location;

                Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
                this.inquilinoActual = inquilinoSeleccionado;
                
                if (inquilinoSeleccionado != null)
                {
                    // Mostrar el nombre del inquilino en algún control, por ejemplo, un label
                    lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                    lblInquilinoSeleccionado.Location =  new Point(70, 19);

                    
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
            Inquilino inquilinoSeleccionado = (Inquilino)cmbInquilinoSeleccionado.SelectedItem;
            this.inquilinoActual = inquilinoSeleccionado;
            if (inquilinoSeleccionado != null)
            {
                lblInquilinoSeleccionado.Text = $"INQUILINO: {inquilinoSeleccionado.ToString()}";
                lblInquilinoSeleccionado.Location = new Point(70, 19);

                // Update the data in DataGridViews based on the selected Inquilino
                CargarPagos();
                CargarDeudas();
            }
        }
        public enum TipoUsuario
        {
            Administrador,
            Inquilino
        }

        public TipoUsuario UsuarioActual { get; private set; }

        // ... otros métodos y eventos ...

        // Añade este método para establecer el administrador actual
        public void SetAdministrador(Administrador administrador)
        {
            
            administradorActual = administrador;
            UsuarioActual = TipoUsuario.Administrador;
            //

            // Verificar si hay un inquilino seleccionado
            
        }

        // Añade este método para establecer el inquilino actual
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


    }

}

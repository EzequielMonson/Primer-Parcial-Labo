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

namespace UI
{
    public partial class FrmMenu : Form
    {
        private Administrador administradorActual;
        private Inquilino inquilinoActual;

        public void FrmMenu_Load(object sender, EventArgs e)
        { 
        
        }
        // Agrega esta propiedad para determinar el tipo de usuario
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
            //MostrarInquilinosACargo();
        }

        // Añade este método para establecer el inquilino actual
        public void SetInquilino(Inquilino inquilino)
        {
            inquilinoActual = inquilino;
            UsuarioActual = TipoUsuario.Inquilino;
        }
        private void CargarPagos()
        {
            // Asumiendo que Inquilino tiene una propiedad List<Pago> llamada Pagos
            List<Pago> listaPagos = inquilinoActual.HistorialPagos;

            dtgPagos.Rows.Clear();

            foreach (var pago in listaPagos)
            {
                // Añadir una nueva fila y llenar las columnas específicas
                int rowIndex = dtgPagos.Rows.Add();
                dtgPagos.Rows[rowIndex].Cells["fechaAbonoPagos"].Value = pago.FechaAbono;
                dtgPagos.Rows[rowIndex].Cells["cantidadAbonadaPagos"].Value = pago.CantidadAbonada;
                dtgPagos.Rows[rowIndex].Cells["fechaVencimientoPagos"].Value = pago.FechaVencimiento;
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

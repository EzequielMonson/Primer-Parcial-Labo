using UI;

namespace NestApp
{
    public partial class FrmInicio : Formulario
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
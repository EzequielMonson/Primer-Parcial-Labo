using UI;

namespace NestApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
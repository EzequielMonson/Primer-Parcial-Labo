using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Formulario : Form
    {
        private bool dragging = false;
        private Point dragStartPoint;
        public Formulario()
        {
            InitializeComponent();
            //this.MouseDown += MainForm_MouseDown;
            //this.MouseMove += MainForm_MouseMove;
            //this.MouseUp += MainForm_MouseUp;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dragOffset = new Point(e.X - dragStartPoint.X, e.Y - dragStartPoint.Y);
                Location = new Point(Location.X + dragOffset.X, Location.Y + dragOffset.Y);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    
    protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

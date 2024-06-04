using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al C#.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau.");
        }

        private void bttPres_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el Click! !! ATENCION!!.");
            //this.BackColor = Color.Blue;
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //MessageBox.Show("Se disparo el Click Izquierdo! !! ATENCION!!.");
            //else if (click.Button == MouseButtons.Right)
            //MessageBox.Show("Se disparo el Click Derecho! !! ATENCION!!.");
            //if (click.Button == MouseButtons.Middle)
            //MessageBox.Show("Se disparo el Click del centro! !! ATENCION!!.");

            if (tbx1.Text == "")
                tbx1.BackColor = Color.Red;
            else
                tbx1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            lblTitulo.BackColor = Color.Cyan;
            lblTitulo.Cursor = Cursors.Hand;
        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            lblTitulo.Cursor = Cursors.Arrow;
        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void tbx2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tbx2.Text.Length + " caracteres.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Interfaz
{
    public partial class FormPrestamo : Form
    {
        private VentanaPrincipal principal;
        public FormPrestamo(VentanaPrincipal p)
        {
            InitializeComponent();
            principal = p;
        }

        private void labNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrEmpty(txtPrestamo.Text) || String.IsNullOrEmpty(txtCuotas.Text)|| String.IsNullOrEmpty(txtPocen.Text))
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
            else
            {
                try
                {
                    Convert.ToDouble(txtPocen.Text);
                    Convert.ToInt32(txtCuotas.Text);
                    Convert.ToDouble(txtPrestamo.Text);
                }
                catch
                {
                    MessageBox.Show("Favor ingresar un numero valido.");
                }
                principal.prestarDos(txtPrestamo.Text, txtCuotas.Text, txtPocen.Text);
            }
        }
    }
}

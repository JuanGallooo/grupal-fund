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
    public partial class CrearFondo : Form
    {
        private Principal p;
        public CrearFondo(Principal principal)
        {
            p = principal;
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String valor = txtValor.Text;
            try
            {
                Convert.ToInt32(valor);
                MessageBox.Show("Se a creado el fondo con exito");
                p.CrearFondo(nombre,valor);
               // Visible = false;
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message);
            }
        }
    }
}

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
    public partial class AgregarMiembro : Form
    {
        private VentanaPrincipal principal;
        private bool terceario;

        public bool Terceario { get => terceario; set => terceario = value; }

        public AgregarMiembro(VentanaPrincipal p, bool Terceario)
        {
            terceario = Terceario;
            principal = p;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if( terceario== false)
            {
            principal.agregarMiembro(txtNombre.Text,txtCedula.Text,txtTelefono.Text,txtCorreo.Text, txtDireccion.Text, txtReferencia.Text);
            }
            else
            {
                principal.agregarMiembroT(txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtReferencia.Text);        
            }
        }

        private void AgregarMiembro_Load(object sender, EventArgs e)
        {

        }
    }
}

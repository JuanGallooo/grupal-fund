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
    public partial class ModificarMiembro : Form
    {
        private VentanaPrincipal principal;
        private bool terceario;

        public bool Terceario { get => terceario; set => terceario = value; }

        public ModificarMiembro(VentanaPrincipal p, bool Terceario, String nombre, String cedula, String telefono, String correo, String direccion, String referencia)
        {
            terceario = Terceario;
            principal = p;
            InitializeComponent();
            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
            txtReferencia.Text= referencia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if( terceario== false)
            {
            principal.ModificarMiembro(txtNombre.Text,txtCedula.Text,txtTelefono.Text,txtCorreo.Text, txtDireccion.Text, txtReferencia.Text);
            }
            else
            {
            principal.ModificarMiembroT(txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtReferencia.Text);        
            }
        }

        private void AgregarMiembro_Load(object sender, EventArgs e)
        {

        }
    }
}

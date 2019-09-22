using Principal.Interfaz;
using Principal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        private FondoGrupal mundo;

        internal FondoGrupal Mundo { get => mundo; set => mundo = value; }

        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //String ruta = "../../Data/infoData.txt";
            //StreamReader sr = new StreamReader(ruta);
            //int line = Convert.ToInt32(sr.ReadLine());
            //int line2 = Convert.ToInt32(sr.ReadLine());
            //sr.Close();
            String contra = txtContra.Text;
            String contra2 = txtUsuario.Text;

            int a = 1398;
            int b = 1389;

            int suma = 0;
            int suma2 = 0;
            for (int i = 0; i < contra.Length; i++)
            {
                suma += Encoding.ASCII.GetBytes(contra)[i];
            }
            for (int i = 0; i < contra2.Length; i++)
            {
                suma2 += Encoding.ASCII.GetBytes(contra2)[i];
            }
            if ( suma== a && suma2== b)
            {
                btnCargar.Visible= true;
                btnNuevo.Visible = true;
            }
            else MessageBox.Show("Usuario o contraseña incorrecta.");
        }

        internal string getRendimientoAporte()
        {
            return mundo.getRendimientoAporte();
        }

        internal void agregarMiembroT(String cedulaOriginal,string nombre, string cedula, string telefono, string correo, String direccion, String referencia)
        {
            try
            {
            mundo.AgregarMiembroTercerario(cedulaOriginal,nombre, cedula, telefono, correo, Mundo.FechaCreacion, direccion,referencia);
            MessageBox.Show("Miembro Agregado con éxito.");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }

        public void agregarMiembro(string nombre, string cedula, string telefono, string correo, String direccion, String referencia)
        {
            try
            {
            mundo.agregarMiembro(nombre, cedula, telefono, correo,Mundo.FechaCreacion, direccion,referencia);
            MessageBox.Show("Miembro Agregado con éxito.");
            }
            catch( Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }
        private VentanaPrincipal miVentanaPrincipal;
        public void CrearFondo(string nombre, string valor)
        {
            if (Convert.ToInt32(valor) < 0) MessageBox.Show("Error : No se puede crear un fondo con valor de aporte negativo");
            else
            {

            Mundo = new FondoGrupal(nombre, DateTime.Today, 0, Convert.ToInt32(valor));
            miVentanaPrincipal= new VentanaPrincipal(this);
            miVentanaPrincipal.StartPosition = FormStartPosition.CenterParent;
            miVentanaPrincipal.ShowDialog();
            Visible = false;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Mundo = new FondoGrupal("FONDO VACIO", DateTime.Today, 0, Convert.ToInt32(2));
            miVentanaPrincipal = new VentanaPrincipal(this);
            miVentanaPrincipal.mostrarVen();
            miVentanaPrincipal.StartPosition = FormStartPosition.CenterParent;
            miVentanaPrincipal.ShowDialog();
            Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearFondo vent = new CrearFondo(this);
            vent.StartPosition = FormStartPosition.CenterParent;
            vent.ShowDialog();
        }

        internal Miembro buscarMiembro(String cedula)
        {
           return Mundo.buscarMiembro(cedula);
        }

        internal void eliminarMiembro(string userAnswer)
        {
            try {
            mundo.eliminarMiembro(userAnswer);
            miVentanaPrincipal.actualizarListaMiembros(true);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }

        internal Miembro buscarMiembroT(string cedula,String cedula2)
        {
            Miembro encontro=null;
            try
            {
               encontro= Mundo.buscarMiembroT(cedula, cedula2);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message + e.StackTrace);
            }
            return encontro;
        }

        internal void eliminarMiembroT(string cedulaP, string userAnswer)
        {
            try
            {
                mundo.EliminarMiembroTerceario(cedulaP, userAnswer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message+ e.StackTrace);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        internal string obtenerRuta()
        {
            string path="";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;

                
            }
            return path;
        }

        public void modificarMiembroT(string cedulaPrincipal, string nombre, string cedula, string telefono, string correo, string direccion, string referencia)
        {
            mundo.modificarMiembroT(cedulaPrincipal, nombre, cedula,  telefono,  correo, direccion, referencia);
        }

        public void modificarMiembro(string nombre, string cedula, string telefono, string correo, string direccion, string referencia)
        {
            mundo.modificarMiembro(nombre, cedula, telefono, correo, direccion, referencia);
        }
    }
}

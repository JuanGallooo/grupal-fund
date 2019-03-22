using Principal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Interfaz
{
    public partial class VentanaPrincipal : Form
    {
        private Principal principal;
        private bool tercerario;

        public bool Tercerario { get => tercerario; set => tercerario = value; }

        public VentanaPrincipal(Principal p)
        {
            principal = p;
            InitializeComponent();
            ventanaAgregar = new AgregarMiembro(this, false);
            ventanaAgregar.StartPosition = FormStartPosition.CenterParent;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            actualizarListaMiembros(true);
            dateTimePicker1.Value = principal.Mundo.FechaCreacion;
            actualizarInfoFondo();
        }
        public void actualizarInfoFondo()
        {
            infoNombreFondo.Text = principal.Mundo.NombreFondo;
            infoAportes.Text = "" + principal.Mundo.NumAportes.Count();
            infoValorAporte.Text = "" + principal.Mundo.ValorAporte;
            infoRendimiento.Text = "" + principal.getRendimientoAporte();
            infoTotalMiembros.Text = "" + principal.Mundo.Miembros.Count();
            infoDineroPrestamo.Text = principal.Mundo.getTotalPrestado();
            infoDisponible.Text = "" + principal.Mundo.MontoTotal;
            infoGanancias.Text = "" + (principal.Mundo.Ganancias+ principal.Mundo.rendimientosFuturos());
        }



        public void agregarMiembro(String nombre, String cedula, String telefono, string correo, String direccion, String referencia)
        {
            principal.agregarMiembro(nombre, cedula, telefono, correo, direccion, referencia);
            actualizarInfoMiembro(nombre, cedula, principal.Mundo.FechaCreacion, 0 + "", telefono, correo, direccion, referencia);
            actualizarListaMiembros(false);
            ventanaAgregar.Visible = false;
            actualizarInfoFondo();
        }

        internal void agregarMiembroT(string nombre, string cedula, string telefono, string correo, String direccion, String referencia)
        {
            ListViewItem seleccion = listMiembros.SelectedItems[0];
            String cedulaPrincipal = seleccion.SubItems[1].Text;

            principal.agregarMiembroT(cedulaPrincipal, nombre, cedula, telefono, correo, direccion, referencia);
            actualizarInfoMiembro(nombre, cedula, principal.Mundo.FechaCreacion, 0 + "", telefono, correo, direccion, referencia);
            actualizarListaMiembrosT(cedulaPrincipal, false);
            ventanaAgregar.Visible = false;
            actualizarInfoFondo();
        }

        public void actualizarListaMiembros(bool mostrarPrimero)
        {
            listMiembros.Items.Clear();
            List<Miembro> lista = principal.Mundo.Miembros;
            foreach (var a in lista)
            {
                try
                {
                    ListViewItem item = new ListViewItem(a.NumeroMiembro + "");
                    item.SubItems.Add(a.Cedula);
                    item.SubItems.Add(a.Nombre);
                    item.SubItems.Add(a.Aportes.Count() + "");
                    if (a.PrestamoMiembro != null)
                    {
                        item.SubItems.Add(a.PrestamoMiembro.SaldoRestante + "");
                    }
                    else item.SubItems.Add(0 + "");
                    listMiembros.Items.Add(item);
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.Message);
                }

            }
            if (mostrarPrimero == true)
            {

                if (lista.Count() != 0)
                {
                    Miembro info = lista.FirstOrDefault();
                    actualizarInfoMiembro(info.Nombre, info.Cedula, info.FechaIngreso, info.Aportes.Count() + "", info.Telefono, info.Correo, info.Direccion, info.Referencia);
                }
            }
            actualizarInfoFondo();
        }

        internal void cargar()
        {
            cargarVentana();
        }

        public void actualizarListaMiembrosT(String cedulaPrincipal, bool mostrarPrimero)
        {
            listMiembrosT.Items.Clear();
            List<Miembro> lista = principal.Mundo.Miembros.Find(x => x.Cedula.Equals(cedulaPrincipal)).MiembrosT;
            foreach (var a in lista)
            {
                try
                {
                    ListViewItem item = new ListViewItem(a.Cedula);
                    item.SubItems.Add(a.Nombre + "");
                    if (a.PrestamoMiembro != null)
                    {
                        item.SubItems.Add(a.PrestamoMiembro.SaldoRestante + "");
                    }
                    else item.SubItems.Add(0 + "");
                    listMiembrosT.Items.Add(item);
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.Message);
                }

            }
            if (mostrarPrimero == true)
            {

                if (lista.Count() != 0)
                {
                    Miembro info = lista.FirstOrDefault();
                    actualizarInfoMiembro(info.Nombre, info.Cedula, info.FechaIngreso, info.Aportes.Count() + "", info.Telefono, info.Correo, info.Direccion, info.Referencia);

                }
            }
            actualizarInfoFondo();
        }

        private void actualizarInfoMiembro(String nombre, String cedula, DateTime ingreso, string aportes, String telefono, String correo, String direccion, string referencia)
        {
            infoNombre.Text = nombre;
            infoCedula.Text = cedula;
            infoFecha.Text = ingreso.ToShortDateString();
            infoAportesTotales.Text = aportes;
            infoTelefono.Text = telefono;
            infoCorreo.Text = correo;
            infoDireccion.Text = direccion;
            infoReferencia.Text = referencia;
            actualizarInfoFondo();
        }
        private AgregarMiembro ventanaAgregar;


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventanaAgregar = new AgregarMiembro(this, false);
            ventanaAgregar.Terceario = false;
            ventanaAgregar.Visible = true;
            ventanaAgregar.StartPosition = FormStartPosition.CenterParent;
            actualizarInfoFondo();
        }

        private void listMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMiembros.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listMiembros.SelectedItems[0];
                String cedula = seleccion.SubItems[1].Text;
                Miembro buscar = principal.buscarMiembro(cedula);
                actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                tercerario = false;
                actualizarListaMiembrosT(cedula, false);
            }
            actualizarInfoFondo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la cedula del miembro que desea eliminar : ", "Eliminar", "");
            principal.eliminarMiembro(UserAnswer);
            actualizarInfoFondo();
            actualizarListaMiembros(true);
            actualizarInfoFondo();
        }

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            if (listMiembros.SelectedItems.Count > 0)
            {

                ventanaAgregar = new AgregarMiembro(this, true);
                ventanaAgregar.Visible = true;
                ventanaAgregar.StartPosition = FormStartPosition.CenterParent;
                actualizarInfoFondo();

            }
            else MessageBox.Show("Primero Selecciona un miembro principal para agregar el miembro terceario.");
        }

        private void listMiembrosT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMiembrosT.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listMiembrosT.SelectedItems[0];
                String cedula = seleccion.Text;

                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion2 = listMiembros.SelectedItems[0];
                    String cedula2 = seleccion2.SubItems[1].Text;
                    Miembro buscar = principal.buscarMiembroT(cedula2, cedula);
                    actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                    tercerario = true;
                }
                else MessageBox.Show("Primero seleccione un miembro principal");
            }
            actualizarInfoFondo();
        }

        private void btnEliminarT_Click(object sender, EventArgs e)
        {
            if (listMiembros.SelectedItems.Count > 0)
            {
                ListViewItem seleccion2 = listMiembros.SelectedItems[0];
                string cedula2 = seleccion2.SubItems[1].Text;
                string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la cedula del miembro que desea eliminar : ", "Eliminar", "");
                principal.eliminarMiembroT(cedula2, UserAnswer);
                actualizarListaMiembrosT(cedula2, true);
                actualizarListaMiembros(true);
            }
            else MessageBox.Show("Primero seleccione un miembro principal");
            actualizarInfoFondo();
        }

        private void btnReporteMiembro_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    Miembro buscar = principal.buscarMiembro(cedula);
                    actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                    Reporte nueva = new Reporte(principal.Mundo.GenerarReporteMiembro(cedula));
                    nueva.StartPosition = FormStartPosition.CenterParent;
                    nueva.ShowDialog();
                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    if (listMiembrosT.SelectedItems.Count > 0)
                    {
                        ListViewItem seleccion2 = listMiembrosT.SelectedItems[0];
                        String cedula2 = seleccion2.Text;
                        Miembro buscar = principal.buscarMiembroT(cedula, cedula2);

                        actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                        Reporte nueva = new Reporte(principal.Mundo.GenerarReporteMiembroT(cedula, cedula2));
                        nueva.StartPosition = FormStartPosition.CenterParent;
                        nueva.ShowDialog();
                    }
                    else MessageBox.Show("seleccione un miembro terceario primero");
                }
                else MessageBox.Show("seleccione un miembro primario primero");
            }
            actualizarInfoFondo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    int numero = 0;
                    try
                    {
                        numero = Convert.ToInt32(textBox1.Text);
                        if (numero < 0)
                        {
                            MessageBox.Show("No se admite un valor negativo, si desea eliminar aportes existe el boton (-)");
                        }
                        else
                        {


                        principal.Mundo.AgregarAporte(numero, cedula);
                        Miembro buscar = principal.buscarMiembro(cedula);
                        actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                        actualizarListaMiembrosT(cedula, false);
                        MessageBox.Show("Se han agregado los aportes con exito.");
                        }
                    }
                    catch (Exception C)
                    {
                        MessageBox.Show(C.Message);
                    }

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                MessageBox.Show("Error:  a un miembro terceario no se le pueden asignar aportes, solo una deuda.");
            }
            actualizarInfoFondo();
            actualizarListaMiembros(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    int numero = 0;
                    try
                    {
                        numero = Convert.ToInt32(textBox1.Text);
                        if( numero< 0)
                        {
                            MessageBox.Show("No se admiten valores negativos, poner el valor en positivo.");
                        }
                        else
                        {

                        principal.Mundo.EliminarAporte(numero, cedula);
                        Miembro buscar = principal.buscarMiembro(cedula);
                        actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                        actualizarListaMiembrosT(cedula, false);
                            MessageBox.Show("Se han eliminado los aportes con exito. ");
                        }
                    }
                    catch (Exception C)
                    {
                        MessageBox.Show(C.Message);
                    }

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                MessageBox.Show("Error:  a un miembro terceario no se le pueden asignar aportes, solo una deuda.");
            }
            actualizarInfoFondo();
            actualizarListaMiembros(false);
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    FormPrestamo pres = new FormPrestamo(this);
                    pres.StartPosition = FormStartPosition.CenterParent;
                    pres.ShowDialog();

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    if (listMiembrosT.SelectedItems.Count > 0)
                    {
                        ListViewItem seleccion2 = listMiembrosT.SelectedItems[0];
                        String cedula2 = seleccion2.Text;


                        FormPrestamo pres = new FormPrestamo(this);
                        pres.StartPosition = FormStartPosition.CenterParent;
                        pres.ShowDialog();

                        actualizarListaMiembrosT(cedula, false);
                    }
                    else MessageBox.Show("seleccione un miembro terceario primero");
                }
                else MessageBox.Show("seleccione un miembro primario primero");
            }
            actualizarInfoFondo();
            actualizarListaMiembros(false);
        }
        internal void prestarDos(string prestamo, string cuotas, string interes)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    try
                    {
                        ListViewItem seleccion = listMiembros.SelectedItems[0];
                        String cedula = seleccion.SubItems[1].Text;

                        Miembro buscar = principal.buscarMiembro(cedula);
                        
                        if(buscar.PrestamoMiembro== null)
                        {
                        principal.Mundo.RealizarPrestamo(cedula, Convert.ToDouble(prestamo), Convert.ToInt32(cuotas), Convert.ToDouble(interes)/100);
                        }
                        else
                        {
                            if((MessageBox.Show("¿Desea modificar la deuda por una nueva?", " Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)){
                                principal.Mundo.RealizarPrestamo(cedula, Convert.ToDouble(prestamo), Convert.ToInt32(cuotas), Convert.ToDouble(interes) / 100);
                            }

                        }
                        actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                        actualizarListaMiembrosT(cedula, false);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;
                    if (listMiembrosT.SelectedItems.Count > 0)
                    {
                        try
                        {
                            ListViewItem seleccion2 = listMiembrosT.SelectedItems[0];
                            String cedula2 = seleccion2.Text;
                            Miembro buscar = principal.buscarMiembroT(cedula, cedula2);

                            if(buscar.PrestamoMiembro == null)
                            {
                            principal.Mundo.RealizarPrestamoT(cedula, cedula2, Convert.ToDouble(prestamo), Convert.ToInt32(cuotas), Convert.ToDouble(interes)/100);
                            }
                            else
                            {
                                if ((MessageBox.Show("¿Desea modificar la deuda por una nueva?", " Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)){
                                    principal.Mundo.RealizarPrestamoT(cedula, cedula2, Convert.ToDouble(prestamo), Convert.ToInt32(cuotas), Convert.ToDouble(interes) / 100);
                                }
                            }

                            actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                            actualizarListaMiembrosT(cedula, false);
                        }
                        catch (Exception d)
                        {

                            MessageBox.Show(d.Message);
                        }

                    }
                    else MessageBox.Show("seleccione un miembro terceario primero");
                }
                else MessageBox.Show("seleccione un miembro primario primero");
            }
            MessageBox.Show("Se ha prestado con éxito");
            actualizarInfoFondo();
        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    try
                    {
                        ListViewItem seleccion = listMiembros.SelectedItems[0];
                        String cedula = seleccion.SubItems[1].Text;
                        principal.Mundo.PagarCuota(cedula);

                        Miembro buscar = principal.buscarMiembro(cedula);
                        actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                        actualizarListaMiembrosT(cedula, false);
                        actualizarListaMiembros(false);
                        MessageBox.Show("La cuota ha sido pagada.");
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    try
                    {
                        ListViewItem seleccion = listMiembros.SelectedItems[0];
                        String cedula = seleccion.SubItems[1].Text;
                        if (listMiembrosT.SelectedItems.Count > 0)
                        {
                            ListViewItem seleccion2 = listMiembrosT.SelectedItems[0];
                            String cedula2 = seleccion2.Text;

                            principal.Mundo.PagarCuotaT(cedula, cedula2);
                            Miembro buscar = principal.buscarMiembroT(cedula, cedula2);
                            MessageBox.Show("La cuota ha sido pagada.");
                            actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                            actualizarListaMiembrosT(cedula, false);
                        }
                        else MessageBox.Show("seleccione un miembro terceario primero");
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
                else MessageBox.Show("seleccione un miembro primario primero");
            }
            actualizarInfoFondo();
            actualizarListaMiembros(false);
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if (tercerario == false)
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    try
                    {
                        ListViewItem seleccion = listMiembros.SelectedItems[0];
                        String cedula = seleccion.SubItems[1].Text;
                        if (MessageBox.Show("¿Desea saldar la deuda del miembro?", " Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                                double abonado = 0;
                                Miembro buscar = principal.buscarMiembro(cedula);
                                if (buscar.PrestamoMiembro != null) abonado = buscar.PrestamoMiembro.SaldoRestante;
                                principal.Mundo.AbonarDeuda(cedula);

                                MessageBox.Show("Se ha abonado un total de $"+ abonado);

                                actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                                actualizarListaMiembrosT(cedula, false);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }

                }
                else MessageBox.Show("Selecciona un miembro primero");
            }
            else
            {
                if (listMiembros.SelectedItems.Count > 0)
                {
                    try
                    {
                        ListViewItem seleccion = listMiembros.SelectedItems[0];
                        String cedula = seleccion.SubItems[1].Text;
                        if (listMiembrosT.SelectedItems.Count > 0)
                        {
                            ListViewItem seleccion2 = listMiembrosT.SelectedItems[0];
                            String cedula2 = seleccion2.Text;
                                try
                                {
                                if (MessageBox.Show("¿Desea saldar la deuda del miembro?", " Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    double abonado = 0;
                                    Miembro buscar = principal.buscarMiembroT(cedula, cedula2);
                                    if (buscar.PrestamoMiembro != null) abonado = buscar.PrestamoMiembro.SaldoRestante;
                                    principal.Mundo.AbonarDeudaT(cedula,cedula);
                                    MessageBox.Show("Se ha abonado un total de $" + abonado);

                                    actualizarInfoMiembro(buscar.Nombre, buscar.Cedula, buscar.FechaIngreso, buscar.Aportes.Count() + "", buscar.Telefono, buscar.Correo, buscar.Direccion, buscar.Referencia);
                                    actualizarListaMiembrosT(cedula, false);
                                }
                                }
                                catch (Exception w)
                                {
                                    MessageBox.Show(w.Message);
                                }
                            }
                        else MessageBox.Show("seleccione un miembro terceario primero");
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
                else MessageBox.Show("seleccione un miembro primario primero");
            }
            actualizarInfoFondo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            Reporte nueva = new Reporte(principal.Mundo.GenerarReporteGeneral());
            nueva.StartPosition = FormStartPosition.CenterParent;
            nueva.ShowDialog();
        }

        private void labelMonto_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            principal.Mundo.FechaCreacion = dateTimePicker1.Value.Date;
            MessageBox.Show("Se han actualizado la fecha de la sesión.");
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            if (principal.Mundo.Rendimientos.ContainsKey(dateTimePicker1.Value.Date))
            {
                if (MessageBox.Show("Ya existe un registro de " +
                    "rendimiento del aporte para esta fecha, desea agregar otra?", " Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    principal.Mundo.cerrarSesion();
                    MessageBox.Show("Sesion Cerrada");
                    actualizarInfoFondo();
                }
            }
            else
            {
                principal.Mundo.cerrarSesion();
                MessageBox.Show("Sesion Cerrada");
                actualizarInfoFondo();
            }
            if (MessageBox.Show("Desea hacer un respaldo de datos? ", "Contesta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                btnGuardar_Click(sender,e);
            }

        }

        private void btnCalcularPagoM_Click(object sender, EventArgs e)
        {
            if (listMiembros.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem seleccion = listMiembros.SelectedItems[0];
                    String cedula = seleccion.SubItems[1].Text;


                    Reporte nueva = new Reporte(principal.Mundo.calcularPagoMiembro(cedula));
                    nueva.StartPosition = FormStartPosition.CenterParent;
                    nueva.ShowDialog();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

        }

        private void btnCalcularPagosF_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte nueva = new Reporte(principal.Mundo.calcularPagosMiembros());
                nueva.StartPosition = FormStartPosition.CenterParent;
                nueva.ShowDialog();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarVentana();
        }
        private void cargarVentana()
        {
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            while (true)
            {
                if (ruta == null || !ruta.Equals("")) break;
            }
            if (ruta != null)
            {
                principal.Mundo.RealizarCopia(ruta);
                actualizarInfoFondo();
                actualizarListaMiembros(true);
                ruta = "";
            }
        }
        static String ruta = "";
        public static void ThreadProc()
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                String path = file.SelectedPath;
                ruta = path;
            }
            else ruta = null;
        }


        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            mostrarVen();
        }
        public void mostrarVen()
        {
            Thread t = new Thread(new ThreadStart(ThreadPrec));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            while (true)
            {
                if (ruta == null || !ruta.Equals("")) break;
            }
            if (ruta != null)
            {
                principal.Mundo = new FondoGrupal();
                principal.Mundo.Cargardatos(ruta);
                actualizarInfoFondo();
                actualizarListaMiembros(true);
                ruta = "";
            }
        }
        public static void ThreadPrec()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                ruta = file.FileName;

            }
            else ruta = null;
        }
    }
}

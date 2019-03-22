using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class Miembro : Persona
    {
        private DateTime fechaIngreso;
        private bool terceario;


        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public List<Miembro> MiembrosT { get => miembrosT; set => miembrosT = value; }
        public List<Aporte> Aportes { get => aportes; set => aportes = value; }
        public Prestamo PrestamoMiembro { get => prestamoMiembro; set => prestamoMiembro = value; }
        public bool Terceario { get => terceario; set => terceario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public int NumeroMiembro { get => numeroMiembro; set => numeroMiembro = value; }
        
        
        private String direccion;
        private String referencia;
        private int numeroMiembro;

        private List<Miembro> miembrosT;
        private List<Aporte> aportes;
        private Prestamo prestamoMiembro;

        public Miembro(string nombre, string cedula, string telefono, string correo, DateTime fechaIngreso,bool tercerario, string direccion, string referencia)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
            Terceario = terceario;
            Direccion = direccion;
            Referencia = referencia;

            miembrosT = new List<Miembro>();
            aportes = new List<Aporte>();
        }
        public void agregarMiembroTercerario(string nombre, string cedula, string telefono, string correo, DateTime fechaIngreso, String direccion, String referencia)
        {
            Miembro nuevo = new Miembro(nombre,cedula,telefono,correo,fechaIngreso,true,direccion,referencia);
            if (miembrosT.Find(x => x.Cedula.Equals(cedula)) != null) throw new Exception("El miembro ya existe");
            miembrosT.Add(nuevo);
        }
        public void eliminarMiembroTerceario(String cedula)
        {
            if (miembrosT.Find(x => x.Cedula.Equals(cedula)) == null) throw new Exception("El miembro solicitado no existe");
            miembrosT.RemoveAll(x=> x.Cedula.Equals(cedula));
        }
        public void eliminarAporte()
        {
            aportes.RemoveAt(0);
        }
        public void agregarPrestamo(double prestamoTotal, double saldoRestante, int numCuotas, double cuota, bool estado, double interes, int numAportes)
        {
                Prestamo nuevo = new Prestamo(prestamoTotal, saldoRestante, numCuotas, cuota, estado, interes,numAportes);
                prestamoMiembro = nuevo;
        }

        public void pagarCuota(double valorAporte)
        {
            if (prestamoMiembro == null) throw new Exception("No hay un prestamo disponible por pagar.");
            prestamoMiembro.pagarCuota(valorAporte);
        }
        public void abonarDeuda()
        {
            prestamoMiembro = null;
        }
    }
}

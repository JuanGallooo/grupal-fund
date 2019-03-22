using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class Asesor: Persona 
    {
        private DateTime fechaIngreso;
        public Asesor(string nombre, string cedula, string telefono, string correo, DateTime fechaIngreso)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
        }

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }
}

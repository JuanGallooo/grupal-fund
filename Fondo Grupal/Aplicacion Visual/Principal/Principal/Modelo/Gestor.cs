using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class Gestor : Persona
    {
        private DateTime fechaCreacion;

        public Gestor(string nombre, string cedula, string telefono, string correo, DateTime fechaCreacion)
        {
            FechaCreacion = fechaCreacion;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
        }

        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        

    }
}

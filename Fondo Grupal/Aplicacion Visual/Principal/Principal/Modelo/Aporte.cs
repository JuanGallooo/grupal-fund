using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class Aporte
    {
        private double valor;
        private DateTime fechaCompra;
        //coments
        public double Valor { get => valor; set => valor = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        public Aporte(double valor, DateTime fechaCompra)
        {
            Valor = valor;
            FechaCompra = fechaCompra;
        }
    }
}

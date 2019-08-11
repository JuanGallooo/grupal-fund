using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class Prestamo
    {
        private double prestamoTotal;
        private double saldoRestante;
        private int numCuotas;
        private double cuota;
        private bool estado;
        private double interes;
        private int numAportes;
        private int cuotasPactadas;
        
        public double PrestamoTotal { get => prestamoTotal; set => prestamoTotal = value; }
        public double SaldoRestante { get => saldoRestante; set => saldoRestante = value; }
        public int NumCuotas { get => numCuotas; set => numCuotas = value; }
        public double Cuota { get => cuota; set => cuota = value; }
        public bool Estado { get => estado; set => estado = value; }
        public double Interes { get => interes; set => interes = value; }
        public int NumAportes { get => numAportes; set => numAportes = value; }
        public int CuotasPactadas { get => cuotasPactadas; set => cuotasPactadas = value; }

        public Prestamo(double prestamoTotal,double saldoRestante, int numCuotas, double cuota, bool estado, double interes, int numAportes,int cuotasPactadas)
        {
            PrestamoTotal = prestamoTotal;
            SaldoRestante = saldoRestante;
            NumCuotas = numCuotas;
            CuotasPactadas = cuotasPactadas;
            Cuota = cuota;
            Estado = estado;
            Interes = interes;
            NumAportes = numAportes;
        }
        public void abonarPrestamo(double valor, double valorAporte)
        {
            if (valor > saldoRestante) throw new Exception("No puede abonar más que el valor del saldo restante.");
            //this.saldoRestante -= NumCuotas*interes*prestamoTotal;
            //saldoRestante -= valor;
            //prestamoTotal -= valor;
            //if (saldoRestante == 0) estado = false;
            //cuota = (saldoRestante / numCuotas)+ (saldoRestante*interes);
            //saldoRestante += (numCuotas * interes * saldoRestante);
            //NumAportes = (int)(saldoRestante / valorAporte); 
            PrestamoTotal -= valor;
            saldoRestante = prestamoTotal + prestamoTotal * interes * numCuotas;
            cuota = prestamoTotal * interes + (prestamoTotal/numCuotas);
        }
        public void prestarMas(double valor, int nuevasCuotas)
        {
            PrestamoTotal += valor;
            saldoRestante =prestamoTotal+ prestamoTotal*interes*numCuotas;
            cuota = prestamoTotal * interes+ (prestamoTotal / numCuotas);
        } 
        public void pagarCuota(double valorAporte)
        {
            saldoRestante -= cuota;
            numCuotas--;
            if (numCuotas == 0) estado = false;
            NumAportes = (int)(saldoRestante / valorAporte);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Modelo
{
    class FondoGrupal
    {
        private String nombreFondo;
        private DateTime fechaCreacion;
        private double montoTotal;

        private List<Miembro> miembros;
        private Gestor gestorFondo;
        private Asesor asesorFondo;
        private List<Aporte> numAportes;
        private double ganancias;
        private double valorAporte;


        public string NombreFondo { get => nombreFondo; set => nombreFondo = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        internal List<Miembro> Miembros { get => miembros; set => miembros = value; }
        internal Gestor GestorFondo { get => gestorFondo; set => gestorFondo = value; }
        internal Asesor AsesorFondo { get => asesorFondo; set => asesorFondo = value; }
        internal List<Aporte> NumAportes { get => numAportes; set => numAportes = value; }
        public double Ganancias { get => ganancias; set => ganancias = value; }
        public double ValorAporte { get => valorAporte; set => valorAporte = value; }
        public List<int> Posiciones { get => posiciones; set => posiciones = value; }

        public Dictionary<DateTime, double> Rendimientos { get => rendimientos; set => rendimientos = value; }

        private List<int> posiciones;

        private Dictionary<DateTime, Double> rendimientos;

        public FondoGrupal()
        {
            nombreFondo = "";
            fechaCreacion = DateTime.Today;
            montoTotal = 0;
            miembros = new List<Miembro>();
            numAportes = new List<Aporte>();
            ganancias = 0;
            valorAporte = 0;
            rendimientos = new Dictionary<DateTime, double>();

            posiciones = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                posiciones.Add(i + 1);
            }
        }
        public FondoGrupal(string nombreFondo, DateTime fechaCreacion, double montoTotal, double valorAporte)
        {
            NombreFondo = nombreFondo;
            FechaCreacion = fechaCreacion;
            MontoTotal = montoTotal;
            rendimientos = new Dictionary<DateTime, Double>();
            Miembros = new List<Miembro>();
            numAportes = new List<Aporte>();
            GestorFondo = null;
            AsesorFondo = null;
            ValorAporte = valorAporte;
            ganancias = 0;
            posiciones = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                posiciones.Add(i + 1);
            }
            //Miembro nuevo1 = new Miembro("Juan", "1", "3166447243", "arroa@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");
            //Miembro nuevo2 = new Miembro("Santiago", "2", "3166447212", "arroaNada@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");
            //Miembro nuevo3 = new Miembro("Daniel", "3", "3145432221", "arroaTercer@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");
            //Miembro nuevo4 = new Miembro("David", "4", "3158643099", "arroa121@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");
            //Miembro nuevo5 = new Miembro("Esteban", "5", "121231312", "arroa3332@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");
            //Miembro nuevo6 = new Miembro("Marco", "6", "31492229112", "arroa4344@nothing.com", DateTime.Today, false, "Carrera 212 # 212-11", "Andres");

            //miembros.Add(nuevo1);
            //miembros.Add(nuevo2);
            //miembros.Add(nuevo3);
            //miembros.Add(nuevo4);
            //miembros.Add(nuevo5);
            //miembros.Add(nuevo6);

            //AgregarAporte(5, "1");
            //AgregarAporte(5, "2");
            //AgregarAporte(5, "3");
            //AgregarAporte(5, "4");
            //AgregarAporte(5, "5");
            //AgregarAporte(5, "6");

            //RealizarPrestamo("2", 100000, 12, 0.05);

            //Console.WriteLine(FechaCreacion.ToLongTimeString());

            //Console.WriteLine(this.getRendimientoAporte());
            //Console.WriteLine("--------------");
            //cerrarSesion();

            //FechaCreacion =new DateTime(2019, 04, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");

            //FechaCreacion = new DateTime(2019, 05, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");

            //FechaCreacion = new DateTime(2019, 06, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");

            //FechaCreacion = new DateTime(2019, 07, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");

            //FechaCreacion = new DateTime(2019, 08, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //FechaCreacion = new DateTime(2019, 09, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //FechaCreacion = new DateTime(2019, 10, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //FechaCreacion = new DateTime(2019, 11, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");

            //FechaCreacion = new DateTime(2019, 12, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //FechaCreacion = new DateTime(2020, 01, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //FechaCreacion = new DateTime(2020, 02, 01);
            //PagarCuota("2");
            //Console.WriteLine(this.getRendimientoAporte());
            //cerrarSesion();
            //Console.WriteLine("--------------");
            //try
            //{
            //    FechaCreacion = new DateTime(2020, 03, 01);
            //    PagarCuota("2");
            //    Console.WriteLine(this.getRendimientoAporte());
            //    cerrarSesion();
            //    Console.WriteLine("--------------");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}
            //Console.WriteLine(calcularPagoMiembro("3"));

        }

        public string getTotalPrestado()
        {
            String retorno = "$ ";
            double suma = 0;
            foreach (var a in miembros)
            {
                if ( a.PrestamoMiembro!= null)
                {
                    suma += a.PrestamoMiembro.SaldoRestante;
                }
                foreach (var d in a.MiembrosT)
                {
                    if( d.PrestamoMiembro!= null)
                    {
                        suma += d.PrestamoMiembro.SaldoRestante;
                    }
                }
            }
            retorno += suma + "";
            return retorno;
        }
        public double getTotalPrestadoNumero()
        {
            double suma = 0;
            foreach (var a in miembros)
            {
                if (a.PrestamoMiembro != null)
                {
                    suma += a.PrestamoMiembro.SaldoRestante;
                }
                foreach (var d in a.MiembrosT)
                {
                    if (d.PrestamoMiembro != null)
                    {
                        suma += d.PrestamoMiembro.SaldoRestante;
                    }
                }
            }
            return suma;
        }
        internal string getRendimientoAporte()
        {
            String retorno = "";
            double rendimiento = (ganancias + rendimientosFuturos()) / numAportes.Count() ;
            retorno += rendimiento;
            return retorno;
        }

        public void agregarMiembro(string nombre, string cedula, string telefono, string correo, DateTime fechaIngreso, String direccion, String referencia)
        {
            if (posiciones.Count() == 0) throw new Exception("No se puede agregar más miembros , ha excedido el limite.");
            if (Miembros.Find(a => a.Cedula == cedula) != null) throw new Exception("El miembro ya existe.");

            Miembro nuevo = new Miembro(nombre, cedula, telefono,
                correo, fechaIngreso, false, direccion, referencia);
            nuevo.NumeroMiembro = posiciones.First();
            posiciones.Remove(posiciones.First());
            if (Miembros.Find(a => a.Cedula == cedula) != null) throw new Exception("El miembro ya existe.");
            Miembros.Add(nuevo);

        }
        public void eliminarMiembro(String cedula)
        {
            if (Miembros.Find(x => x.Cedula.Equals(cedula)) == null) throw new Exception("No se ha encontrado el miembro solicitado.");
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta.PrestamoMiembro != null)
            {
                if (consulta.PrestamoMiembro.Estado == true) throw new Exception("No se puede eliminar un miembro con una deuda activa.");
            }
            if (consulta.MiembrosT.Any() == true)
            {
                foreach (var a in consulta.MiembrosT)
                {
                    if (a.PrestamoMiembro != null && a.PrestamoMiembro.Estado == true) throw new Exception("No se puede eliminar un miembro. Debido a que posee un miembro terceario con una deuda activa.");
                }
            }
            List<Aporte> AportesEliminar = consulta.Aportes;
            montoTotal -= AportesEliminar.Count() * valorAporte;
            foreach (var aporte in AportesEliminar)
            {
                NumAportes.RemoveAll(x => x.Equals(aporte));
            }
            posiciones.Insert(0, consulta.NumeroMiembro);
            Miembros.RemoveAll(x => x.Cedula.Equals(cedula));
        }

        public Miembro buscarMiembro(string cedula)
        {
            return Miembros.Find(x => x.Cedula.Equals(cedula));
        }

        public void AgregarMiembroTercerario(String cedulaOriginal, string nombre, string cedula, string telefono, string correo, DateTime fechaIngreso, String direccion, String referencia)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedulaOriginal));
            if (consulta == null) throw new Exception(" No se ha encontrado el cliente solicitado");
            else
            {
                miembros.Find(x => x.Cedula.Equals(cedulaOriginal)).agregarMiembroTercerario(nombre, cedula, telefono, correo, fechaIngreso, direccion, referencia);
            }
        }

        internal Miembro buscarMiembroT(string cedula, string cedula2)
        {

            Miembro encontro = Miembros.Find(x => x.Cedula.Equals(cedula)).MiembrosT.Find(y => y.Cedula.Equals(cedula2));
            if (encontro == null) throw new Exception("No se encontro el miembro");
            return encontro;
        }

        public void EliminarMiembroTerceario(string cedula, String cedulaTerce)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            miembros.Find(x => x.Cedula.Equals(cedula)).eliminarMiembroTerceario(cedulaTerce);
        }
        public void AgregarAporte(int num, String cedula)
        {
            if (num < 0) throw new Exception("No se puede ingresar un valor negativo");
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            for (int i = 0; i < num; i++)
            {
                Aporte nuevo = new Aporte(valorAporte, fechaCreacion);
                NumAportes.Add(nuevo);
                miembros.Find(x => x.Cedula.Equals(cedula)).Aportes.Add(nuevo);
            }
            montoTotal += num * valorAporte;
        }
        public void EliminarAporte(int num, String cedula)
        {
            montoTotal -= num * valorAporte;
            if (num < 0) throw new Exception("No se puede ingresar un valor negativo");
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            if (consulta.Aportes.Count() < num) throw new Exception("No se puede eliminar mas aportes de los que tiene el miembro");
            for (int i = 0; i < num; i++)
            {
                numAportes.Remove(miembros.Find(x => x.Cedula.Equals(cedula)).Aportes.First());
                miembros.Find(x => x.Cedula.Equals(cedula)).eliminarAporte();
            }
        }
        public void RealizarPrestamo(String cedula, double monto, int numCoutas, double porcentaje)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            if (monto > MontoTotal) throw new Exception("No hay suficientes fondos para el prestamo");
            double couta = (monto / numCoutas) + (porcentaje * monto);
            //if (monto % valorAporte != 0) throw new Exception("Se tiene que prestar en cifras del valor del aporte");
            if (monto < 0 || numCoutas < 0 || porcentaje<0) throw new Exception("No se puede ingresar un valor negativo");
            double PrestamoDis = consulta.Aportes.Count() * 5 * valorAporte;
            if (monto > PrestamoDis) throw new Exception("No se puede prestar más de 5 veces el numero de aportes.");



            int aportesP = (int)(monto / valorAporte);
            montoTotal -= monto;
            double prestamoTotal = monto+0;
            monto += ((porcentaje * monto) * numCoutas);
            miembros.Find(x => x.Cedula.Equals(cedula)).agregarPrestamo(prestamoTotal,monto, numCoutas, couta, true, porcentaje, aportesP);
        }
        public void RealizarPrestamoT(String cedulaPadre, String cedulaHijo, double monto, int numCoutas, double porcentaje)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedulaPadre));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente padre solicitado");
            if (miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)) == null) throw new Exception("No se ha encontrado el cliente terceario solicitado");
            if (monto > MontoTotal) throw new Exception("No hay suficientes fondos para el prestamo");

            double couta = (monto / numCoutas) + (porcentaje * monto);
            //if (monto % valorAporte != 0) throw new Exception("Se tiene que prestar en cifras del valor del aporte");
            if (monto < 0) throw new Exception("No se puede ingresar un valor negativo");

            int aportesP = (int)(monto / valorAporte);

            montoTotal -= monto;
            double prestamoTotal = monto + 0;
            monto += ((porcentaje * monto) * numCoutas);

            miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)).agregarPrestamo(prestamoTotal,monto, numCoutas, couta, true, porcentaje, aportesP);
        }
        public void PagarCuota(String cedula)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            miembros.Find(x => x.Cedula.Equals(cedula)).pagarCuota(valorAporte);

            double saldoTotal = consulta.PrestamoMiembro.PrestamoTotal;
            double interes = consulta.PrestamoMiembro.Interes;

            montoTotal += (consulta.PrestamoMiembro.Cuota - interes * saldoTotal);

            
            if(miembros.Find(x => x.Cedula.Equals(cedula)).PrestamoMiembro.Estado!=false)
            {
                    ganancias += saldoTotal * interes;
            }

            montoTotal += saldoTotal * interes;
            if (miembros.Find(x => x.Cedula.Equals(cedula)).PrestamoMiembro.Estado == false)
            {
                miembros.Find(x => x.Cedula.Equals(cedula)).PrestamoMiembro = null;

                throw new Exception("Se ha cancelado el prestamo en su totalidad");
            }
        }
        public void PagarCuotaT(String cedulaPadre, String cedulaHijo)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedulaPadre));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            Miembro consultaT = miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo));
            if (consultaT == null) throw new Exception("No se ha encontrado el cliente terceario solicitado");
            miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)).pagarCuota(valorAporte);
            double saldoTotal = consultaT.PrestamoMiembro.PrestamoTotal;
            double interes = consultaT.PrestamoMiembro.Interes;
            montoTotal += consultaT.PrestamoMiembro.Cuota - interes * saldoTotal;
            if (miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)).PrestamoMiembro.Estado == false)
            {

                miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)).PrestamoMiembro = null;
                throw new Exception("Se ha cancelado el prestamo en su totalidad");
            }
            else ganancias += saldoTotal * interes;
        }
        public void AbonarDeuda(String cedula)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedula));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            if( consulta.PrestamoMiembro== null) throw new Exception("No hay ninguna deuda por saldar.");

            double abonar = consulta.PrestamoMiembro.SaldoRestante;

            ganancias += consulta.PrestamoMiembro.PrestamoTotal * consulta.PrestamoMiembro.Interes * consulta.PrestamoMiembro.PrestamoTotal * consulta.PrestamoMiembro.NumCuotas;

            miembros.Find(x => x.Cedula.Equals(cedula)).abonarDeuda();


            montoTotal += abonar;
        }
        public void AbonarDeudaT(String cedulaPadre, String cedulaHijo)
        {
            Miembro consulta = miembros.Find(x => x.Cedula.Equals(cedulaPadre));
            if (consulta == null) throw new Exception("No se ha encontrado el cliente solicitado");
            Miembro consultaT = miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo));
            if (consultaT == null) throw new Exception("No se ha encontrado el cliente terceario solicitado");
            if (consultaT.PrestamoMiembro == null) throw new Exception("No hay ninguna deuda por saldar.");
            double abonar = consultaT.PrestamoMiembro.SaldoRestante;
            ganancias += consultaT.PrestamoMiembro.PrestamoTotal * consultaT.PrestamoMiembro.Interes * consultaT.PrestamoMiembro.PrestamoTotal * consultaT.PrestamoMiembro.NumCuotas;

            miembros.Find(x => x.Cedula.Equals(cedulaPadre)).MiembrosT.Find(y => y.Cedula.Equals(cedulaHijo)).abonarDeuda();
            montoTotal += abonar;
        }
        public String GenerarReporteGeneral()
        {
            String retorno = "";
            retorno += "El reporte correspondiente a la fecha " + fechaCreacion.ToShortDateString() + " , da como resultado los siguientes valores: \r\n";
            retorno += "Total aportes en el fondo comprados por miembros: " + numAportes.Count() + "\r\n";

            double prestamoT = 0;
            double prestamoP = 0;
            foreach (var a in miembros)
            {
                if (a.PrestamoMiembro != null) prestamoP += a.PrestamoMiembro.SaldoRestante;

                foreach (var e in a.MiembrosT)
                {
                    if (e.PrestamoMiembro != null) prestamoT += e.PrestamoMiembro.SaldoRestante;
                }
            }
            double prestamoTotal = prestamoT + prestamoP;
            retorno += "Total monto prestado entre miembros principales: $" + prestamoP + "\r\n";
            retorno += "Total monto prestado entre miembros tercerarios: $" + prestamoT + "\r\n";
            retorno += "Total monto prestado entre miembros y terceros: $" + prestamoTotal + "\r\n";
            retorno += "Total monto disponible para prestamo: $" + montoTotal + "\r\n";

            retorno += "Total ganancias de la sesión hasta ahora: $" + ganancias + "\r\n";
            retorno += "Total rendimiento del aporte : $" + (ganancias+rendimientosFuturos()) / numAportes.Count() + "\r\n";

            retorno += "\r\n" + "\r\n";

            retorno += "Acontinuacion se llevara a cabo el reporte por cada usuario...\r\n";

            foreach (var m in miembros)
            {
                retorno += "Nombre : " + m.Nombre + "\r\n";
                retorno += "Numero de aportes totales : " + m.Aportes.Count() + "\r\n";
                if (m.PrestamoMiembro != null)
                {
                    retorno += "Monto total prestado : $" + m.PrestamoMiembro.PrestamoTotal + "\r\n";
                    retorno += "Saldo restante : $" + m.PrestamoMiembro.SaldoRestante + "\r\n";
                    retorno += "Cuota por pagar : $" + m.PrestamoMiembro.Cuota + "\r\n";
                }
                else retorno += "Cuota por pagar : $0" + "\r\n";

                retorno += "Retiro de aportes correspondientes segun las fechas :" + "\r\n";

                var consulta = m.Aportes.GroupBy(e => e.FechaCompra);
                foreach (var a in consulta)
                {
                    DateTime fecha = a.Key;
                    DateTime nueva = new DateTime(a.Key.Year + 1, a.Key.Month, a.Key.Day);
                    retorno += "Los rendimientos de " + a.Count() + " aportes pueden ser retirados apartir del " + nueva.ToLongDateString() + "\r\n";
                   // retorno += "Los rendimientos de " + a.Count() + " aportes pueden ser retirados en el mes " + a.Key + " del próximo año" + "\r\n";
                    //retorno += "Los aportes comprados correspondientes al mes "+ a.Key+" con la cantidad de "+a.Count()+" pueden ser retirados en el mismo mes del otro año." + "\r\n";
                }
                if (m.MiembrosT.Count() != 0)
                {
                    retorno += "Cantidad de miembros Tercerarios:" + m.MiembrosT.Count() + "\r\n";
                    foreach (var e in m.MiembrosT)
                    {
                        retorno += "Nombre : " + e.Nombre + "\r\n";
                        if (e.PrestamoMiembro != null)
                        {
                            retorno += "Monto total prestado : $" + e.PrestamoMiembro.PrestamoTotal + "\r\n";
                            retorno += "Saldo restante : $" + e.PrestamoMiembro.SaldoRestante + "\r\n";
                            retorno += "Cuota por pagar : $" + e.PrestamoMiembro.Cuota + "\r\n";
                        }
                        else retorno += "No tiene ningun prestamo activo." + "\r\n";
                    }
                }
                retorno += "----------------" + "\r\n";
            }
            return retorno;
        }
        public String GenerarReporteMiembro(String cedula)
        {
            String retorno = "";
            Miembro m = miembros.Find(e => e.Cedula.Equals(cedula));
            if (m == null) throw new Exception("No se encuentra el miembro solicitado.");
            retorno += "Nombre : " + m.Nombre + "\r\n";
            retorno += "Numero de aportes totales : " + m.Aportes.Count() + "\r\n";
            if (m.PrestamoMiembro != null)
            {
                retorno += "Monto total prestado : $" + m.PrestamoMiembro.PrestamoTotal + "\r\n";
                retorno += "Saldo restante : $" + m.PrestamoMiembro.SaldoRestante + "\r\n";
                retorno += "Cuota por pagar : $" + m.PrestamoMiembro.Cuota + "\r\n";
                retorno += "Cuotas restantes : $" + m.PrestamoMiembro.NumCuotas + "\r\n";
            }
            else retorno += "Cuota por pagar : $0" + "\r\n";

            retorno += "Retiro de aportes correspondientes segun las fechas :" + "\r\n";

            var consulta = m.Aportes.GroupBy(e => e.FechaCompra);
            foreach (var a in consulta)
            {
                DateTime fecha = a.Key;
                DateTime nueva = new DateTime(a.Key.Year + 1, a.Key.Month, a.Key.Day);
                retorno += "Los rendimientos de " + a.Count() + " aportes pueden ser retirados apartir del  " + nueva.ToLongDateString() + "\r\n";
                //  retorno += "Los aportes comprados correspondientes al mes " + a.Key + " con la cantidad de " + a.Count() + " pueden ser retirados en el mismo mes del otro año." + "\r\n";
            }
            if (m.MiembrosT.Count() != 0)
            {
                retorno += "Cantidad de miembros Tercerarios:" + m.MiembrosT.Count() + "\r\n";
                foreach (var e in m.MiembrosT)
                {
                    retorno += "Nombre : " + e.Nombre + "\n";
                    if (e.PrestamoMiembro != null)
                    {
                        retorno += "Monto total prestado : $" + e.PrestamoMiembro.PrestamoTotal + "\r\n";
                        retorno += "Saldo restante : $" + e.PrestamoMiembro.SaldoRestante + "\r\n";
                        retorno += "Cuota por pagar : $" + e.PrestamoMiembro.Cuota + "\r\n";
                    }
                    else retorno += "No tiene ningun prestamo activo." + "\r\n";
                }
            }
            return retorno;
        }
        public String GenerarReporteMiembroT(String cedulaP, String cedulaT)
        {
            String retorno = "";
            Miembro m = miembros.Find(e => e.Cedula.Equals(cedulaP)).MiembrosT.Find(w => w.Cedula.Equals(cedulaT));
            if (m == null) throw new Exception("No se encuentra el miembro solicitado.");
            retorno += "Nombre : " + m.Nombre + "\r\n";
            if (m.PrestamoMiembro != null)
            {
                retorno += "Monto total prestado : $" + m.PrestamoMiembro.PrestamoTotal + "\r\n";
                retorno += "Saldo restante : $" + m.PrestamoMiembro.SaldoRestante + "\r\n";
                retorno += "Cuota por pagar : $" + m.PrestamoMiembro.Cuota + "\r\n";
            }
            else retorno += "Cuota por pagar : $0" + "\r\n";
            return retorno;

        }
        public void RealizarCopia(String ruta)
        {
            ruta += "/copiaFondo"+"_"+nombreFondo+".txt";
            StreamWriter es = new StreamWriter(ruta);

            es.WriteLine(nombreFondo);
            es.WriteLine(fechaCreacion.ToShortDateString());
            es.WriteLine(montoTotal);
            es.WriteLine(valorAporte);

            es.WriteLine(miembros.Count());

            foreach (var a in miembros)
            {
                es.WriteLine(a.FechaIngreso.ToShortDateString());
                es.WriteLine(a.Terceario);
                es.WriteLine(a.Direccion);
                es.WriteLine(a.Referencia);
                es.WriteLine(a.NumeroMiembro);
                es.WriteLine(a.Nombre);
                es.WriteLine(a.Cedula);
                es.WriteLine(a.Telefono);
                es.WriteLine(a.Correo);
                //fecha-tercerario-direccion-referencia-numeromiembro-nombre-cedula-telefono-correo
                es.WriteLine(a.MiembrosT.Count);

                foreach (var e in a.MiembrosT)
                {
                    es.WriteLine(e.FechaIngreso.ToShortDateString());
                    es.WriteLine(e.Terceario);
                    es.WriteLine(e.Direccion);
                    es.WriteLine(e.Referencia);
                    es.WriteLine(e.Nombre);
                    es.WriteLine(e.Cedula);
                    es.WriteLine(e.Telefono);
                    es.WriteLine(e.Correo);
                    if (e.PrestamoMiembro != null) {
                    es.WriteLine(true);
                        es.WriteLine(e.PrestamoMiembro.PrestamoTotal);
                        es.WriteLine(e.PrestamoMiembro.SaldoRestante);
                        es.WriteLine(e.PrestamoMiembro.NumCuotas);
                        es.WriteLine(e.PrestamoMiembro.Cuota);
                        es.WriteLine(e.PrestamoMiembro.Estado);
                        es.WriteLine(e.PrestamoMiembro.Interes);
                        es.WriteLine(e.PrestamoMiembro.NumAportes);
                    }
                    else
                    {
                        es.WriteLine(false);
                    }

                }
                es.WriteLine(a.Aportes.Count());
                foreach (var i in a.Aportes)
                {
                    es.WriteLine(i.FechaCompra.ToShortDateString());
                }
                if (a.PrestamoMiembro != null)
                {
                    es.WriteLine(true);
                    es.WriteLine(a.PrestamoMiembro.PrestamoTotal);
                    es.WriteLine(a.PrestamoMiembro.SaldoRestante);
                    es.WriteLine(a.PrestamoMiembro.NumCuotas);
                    es.WriteLine(a.PrestamoMiembro.Cuota);
                    es.WriteLine(a.PrestamoMiembro.Estado);
                    es.WriteLine(a.PrestamoMiembro.Interes);
                    es.WriteLine(a.PrestamoMiembro.NumAportes);
                }
                else
                {
                    es.WriteLine(false);
                }

            }

            es.WriteLine(ganancias);
            es.WriteLine(getTotalPrestadoNumero());
            es.WriteLine(posiciones.Count);
            foreach (var c in posiciones)
            {
                es.WriteLine(c);
            }
            es.WriteLine(rendimientos.Count);
            foreach (var b in rendimientos)
            {
                es.WriteLine(b.Key.ToShortDateString()+" "+b.Value);
            }
            es.Close();
        }
        public void Cargardatos(String ruta)
        {
            StreamReader sr = new StreamReader(ruta);
            nombreFondo = sr.ReadLine();
            fechaCreacion = convertirFecha(sr.ReadLine());
            montoTotal = Convert.ToDouble(sr.ReadLine());
            valorAporte = Convert.ToDouble(sr.ReadLine());
            int numMiembros = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < numMiembros; i++)
            {
                DateTime fechaIn = convertirFecha(sr.ReadLine());
                bool terce = Convert.ToBoolean(sr.ReadLine());
                String direccion = sr.ReadLine();
                String referencia = sr.ReadLine();
                int numMiembro = Convert.ToInt32(sr.ReadLine());
                String nombre = sr.ReadLine();
                String cedula = sr.ReadLine();
                String telefono = sr.ReadLine();
                String correo = sr.ReadLine();

                agregarMiembro(nombre, cedula, telefono, correo, fechaIn, direccion, referencia);
                miembros.Find(c => c.Cedula.Equals(cedula)).NumeroMiembro = numMiembro;

                int numMiemT = Convert.ToInt32(sr.ReadLine());

                for (int j = 0; j < numMiemT; j++)
                {
                    DateTime fechaIngresoT = convertirFecha(sr.ReadLine());
                    bool terceario = Convert.ToBoolean(sr.ReadLine());
                    String direccionT = sr.ReadLine();
                    String referenciaT = sr.ReadLine();
                    String nombreT = sr.ReadLine();
                    String cedulaT = sr.ReadLine();
                    String telefonoT = sr.ReadLine();
                    String correoT = sr.ReadLine();
                    AgregarMiembroTercerario(cedula, nombreT, cedulaT, telefonoT, correoT, fechaIngresoT, direccionT, referenciaT);
                    Boolean prestaT = Convert.ToBoolean(sr.ReadLine());
                    if( prestaT== true)
                    {
                        double prestamoTotalT = Convert.ToDouble(sr.ReadLine());
                        double saldoRestanteT = Convert.ToDouble(sr.ReadLine());
                        int numCuotasT = Convert.ToInt32(sr.ReadLine());
                        double cuotaT = Convert.ToDouble(sr.ReadLine());
                        bool estadoT = Convert.ToBoolean(sr.ReadLine());
                        double interesT = Convert.ToDouble(sr.ReadLine());
                        int numAportesT = Convert.ToInt32(sr.ReadLine());

                        Prestamo nuevoT = new Prestamo(prestamoTotalT, saldoRestanteT, numCuotasT, cuotaT, estadoT, interesT, numCuotasT);
                        miembros.Find(c => c.Cedula == cedula).MiembrosT.Find(k => k.Cedula == cedulaT).PrestamoMiembro = nuevoT;
                    }
                }
                int aportes = Convert.ToInt32(sr.ReadLine());
                for (int j = 0; j < aportes; j++)
                {
                    Aporte nuevo = new Aporte(valorAporte, convertirFecha(sr.ReadLine()));
                    numAportes.Add(nuevo);
                    miembros.Find(x=>x.Cedula.Equals(cedula)).Aportes.Add(numAportes.Find(e=>e.Equals(nuevo)));
                }
                Boolean presta = Convert.ToBoolean(sr.ReadLine());
                if (presta == true)
                {
                    double prestamoTotal = Convert.ToDouble(sr.ReadLine());
                    double saldoRestante = Convert.ToDouble(sr.ReadLine());
                    int numCuotas = Convert.ToInt32(sr.ReadLine());
                    double cuota = Convert.ToDouble(sr.ReadLine());
                    bool estado = Convert.ToBoolean(sr.ReadLine());
                    double interes = Convert.ToDouble(sr.ReadLine());
                    int numAportes = Convert.ToInt32(sr.ReadLine());

                    Prestamo nuevo = new Prestamo(prestamoTotal, saldoRestante, numCuotas, cuota, estado, interes, numCuotas);
                    miembros.Find(c => c.Cedula == cedula).PrestamoMiembro = nuevo;
                }
            }
            ganancias = Convert.ToDouble(sr.ReadLine());
            double totalPrestado = Convert.ToDouble(sr.ReadLine());
            int numPos = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < numPos; i++)
            {
                posiciones.Add(Convert.ToInt32(sr.ReadLine()));
            }
            int numRendi = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < numRendi; i++)
            {
                String linea = sr.ReadLine();
                String[] pos = linea.Split(' ');
                rendimientos.Add(convertirFecha(pos[0]), Convert.ToDouble(pos[1]));
            }
            sr.Close();
        }
        public DateTime convertirFecha(String entrada)
        {
            return Convert.ToDateTime(entrada);
        }
        public void cerrarSesion()
        {
            double rendimiento = (ganancias+rendimientosFuturos()) / numAportes.Count();
            if (rendimientos.ContainsKey(fechaCreacion)) rendimientos[fechaCreacion] = rendimiento;
            else
            {
            rendimientos.Add(fechaCreacion, rendimiento);
            }
            ganancias = 0;
        }
        public double rendimientosFuturos()
        {
            double suma = 0;

            foreach (var m in miembros)
            {
                if( m.PrestamoMiembro!= null)
                {
                    suma += m.PrestamoMiembro.PrestamoTotal * m.PrestamoMiembro.Interes;
                }
                foreach (var m2 in m.MiembrosT)
                {
                    if (m2.PrestamoMiembro != null)
                    {
                        suma += m2.PrestamoMiembro.PrestamoTotal * m2.PrestamoMiembro.Interes;
                    }
                }
            }
            return suma;
        }
        public String calcularPagoMiembro(String cedula)
        {
            String retorno = "";
            Miembro m = miembros.Find(e => e.Cedula.Equals(cedula));
            if (m == null) throw new Exception("No se ha encontrado el cliente solicitado");

            retorno += "El pago correspondiente a la fecha " + fechaCreacion.ToShortDateString() + " , da como resultado los siguientes valores: \r\n";

            if (m == null) throw new Exception("No se encuentra el miembro solicitado.");
            retorno += "Nombre : " + m.Nombre + "\r\n";
            retorno += "Número de aportes totales : " + m.Aportes.Count() + "\r\n";

            retorno += "Retiro de aportes correspondientes segun la fecha de hoy: " + "\r\n";

            int contador = 0;
            foreach (var a in m.Aportes)
            {
                //TimeSpan resta = this.fechaCreacion-a.FechaCompra;
                if (fechaCreacion.Month == a.FechaCompra.Month && (fechaCreacion.Year - a.FechaCompra.Year) ==1)contador++;
                //long resta = Math.Abs((a.FechaCompra.Month - fechaCreacion.Month) + 12 * (a.FechaCompra.Month - fechaCreacion.Month));
                //if (resta > 11) contador++;
            }
            if (contador == 0)
            {
                retorno += "No contiene ningun aportes referente a la fecha de hace un año." + "\r\n";
            }
            else
            {
                if (rendimientos.Count() < 12) throw new Exception("No existe suficientes registros de rendimiento para calcular el ");
                else
                {
                    double suma = 0;
                    bool encontro = false;
                    int contadorDos = 0;
                    bool termino = false;
                    foreach (var d in rendimientos)
                    {
                        
                        if (termino == false)
                        {
                            if (encontro == false)
                            {
                                if (fechaCreacion.Month == d.Key.Month && (fechaCreacion.Year - d.Key.Year) == 1)
                                {
                                     encontro = true;
                                     suma += d.Value;
                                    Console.WriteLine(d.Value + d.Key.ToLongDateString());
                                }
                               // long resta = Math.Abs((d.Key.Month - fechaCreacion.Month) + 12 * (d.Key.Month - fechaCreacion.Month));
                                //if (resta > 11) encontro = true;
                            }
                            else
                            {
                                Console.WriteLine(d.Value + d.Key.ToLongDateString());
                                suma += d.Value;
                                contadorDos++;
                                if (contadorDos == 12)
                                {
                                    termino = true;
                                    break;
                                }
                            }
                        }
                    }
                    double pago = suma * contador;
                    retorno += "El pago correspondiente al miembro con respecto al redimiento de sus aportes comprados hace un año son $" + pago + "\r\n";
                }
            }
            return retorno;
        }
        public String calcularPagosMiembros()
        {
            String retorno = "";

            foreach (var m in miembros)
            {

                if (m == null) throw new Exception("No se ha encontrado el cliente solicitado");

                retorno += "El pago correspondiente a la fecha " + fechaCreacion.ToShortDateString() + " , da como resultado los siguientes valores: \r\n";

                if (m == null) throw new Exception("No se encuentra el miembro solicitado.");
                retorno += "Nombre : " + m.Nombre + "\r\n";
                retorno += "Número de aportes totales : " + m.Aportes.Count() + "\r\n";

                retorno += "Retiro de aportes correspondientes segun la fecha de hoy: " + "\r\n";

                int contador = 0;
                foreach (var a in m.Aportes)
                {
                    if (fechaCreacion.Month == a.FechaCompra.Month && (fechaCreacion.Year - a.FechaCompra.Year) == 1) contador++;
                    //TimeSpan resta = this.fechaCreacion-a.FechaCompra;
                   // long resta = Math.Abs((a.FechaCompra.Month - fechaCreacion.Month) + 12 * (a.FechaCompra.Month - fechaCreacion.Month));
                 //   if (resta > 11) contador++;
                }
                if (contador == 0)
                {
                    retorno += "No contiene ningun aportes referente a la fecha de hace un año." + "\r\n";
                }
                else
                {
                    if (rendimientos.Count() < 12) throw new Exception("No existe suficientes registros de rendimiento para calcular el ");
                    else
                    {
                        double suma = 0;
                        bool encontro = false;
                        int contadorDos = 0;
                        bool termino = false;
                        foreach (var d in rendimientos)
                        {
                            if (termino == false)
                            {
                                if (encontro == false)
                                {
                                    if (fechaCreacion.Month == d.Key.Month && (fechaCreacion.Year - d.Key.Year) == 1)
                                    {
                                        encontro = true;
                                        suma += d.Value;
                                        Console.WriteLine(d.Value + d.Key.ToLongDateString());
                                    }

                                    //long resta = Math.Abs((d.Key.Month - fechaCreacion.Month) + 12 * (d.Key.Month - fechaCreacion.Month));
                                  //  if (resta > 11) encontro = true;
                                 //   suma += d.Value;
                               //     contadorDos++;
                                }
                                else
                                {
                                    suma += d.Value;
                                    contadorDos++;
                                    if (contadorDos == 12)
                                    {
                                        termino = true;
                                        break;
                                    }
                                }
                            }
                        }
                        double pago = suma * contador;
                        retorno += "El pago correspondiente al miembro con respecto al redimiento de sus aportes comprados hace un año son $" + pago + "\r\n";
                        retorno+= "\r\n-------------------------------------------------------------------\r\n";
                    }
                }

            }

            return retorno;
        }
    }
}

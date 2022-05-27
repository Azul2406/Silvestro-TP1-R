using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    public class Pedido
    {

        public int idPedido { get; set; }
        public double cantidad { get; set; }
        public DateTime fechaEmision { get; set; }
        public string nombreBancoSangre { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string tipoSangre { get; set; }

        public void NuevoPedido()
        {
            string nombreBancoSangre;
            double cantidad;
            DateTime fechaActual = DateTime.Now;
            DateTime fechaVencimiento;
            string tipoSangre;

            Console.WriteLine("Nombre del Banco de Sangre: ");
            nombreBancoSangre= Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de sangre (litros): ");
            string linea = Console.ReadLine();
            cantidad = double.Parse(linea);
            Console.WriteLine("Ingrese el tipo de sangre necesario: ");
            tipoSangre = Console.ReadLine();
            //Console.WriteLine("Ingrese el año de vencimiento del pedido: ");
            //string year = Console.ReadLine();
            Console.WriteLine("Ingrese el mes de vencimiento del pedido: ");
            string month = Console.ReadLine();
            Console.WriteLine("Ingrese el dia de vencimiento del pedido: ");
            string day = Console.ReadLine();
            fechaVencimiento = new DateTime(DateTime.Now.Year, Int16.Parse(month), Int16.Parse(day));

            Console.WriteLine("Pedido ingresado con exito.");
            //Console.WriteLine("Los asociados que se deberan presentar son: ");

            Turno nuevoTurno = new Turno();
            nuevoTurno.OtorgarTurno(cantidad , tipoSangre, Persona.personasAsociadas);

            
        }


    }
}

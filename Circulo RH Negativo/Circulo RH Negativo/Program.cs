using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Circulo de Sangre RH Negativo.");
            Console.WriteLine("Ingrese la opcion deseada.");
            Console.WriteLine("1 (Agregar nuevo asociado)   \n2 (Realizar nuevo pedido) ");
            string linea = Console.ReadLine();
            num = int.Parse(linea);

            switch (num)
            {
                case 1:
                    Persona persona = new Persona();
                    persona.NuevoAsociado();
                    break;

                default:
                    Persona persona1 = new Persona();
                    Pedido pedido = new Pedido();
                    pedido.NuevoPedido();
                    break;

            }


            Console.ReadKey();

        }
    }
}

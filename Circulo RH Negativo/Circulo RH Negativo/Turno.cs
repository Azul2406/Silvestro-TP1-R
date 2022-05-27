using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    public class Turno
    {
        public void OtorgarTurno(double cantidad, string tipoDeSangre, List<Persona> asociados )
        {
            string var1 = "Activo";
            double cantidadColectada = 0;
           
            if (cantidadColectada <= cantidad)
            {
                foreach (Persona c in asociados)
                {
                    if (c.Categoria.ToLower() == var1.ToLower())
                    {
                        if (c.CantidadDonacionesUltimoAño < 2)
                        {
                            if (tipoDeSangre.ToLower() == c.GrupoSanguineo.ToLower())
                            {
                                Console.WriteLine("Asociado/a: " + c.Nombre + " llamado/a a donar.");
                                cantidadColectada = cantidadColectada + 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Disculpe, no podemos cumplir con sus requerimientos en este momento");
                            }
                        }
                        
                    }
                }

            }
        }
    }
           
}
    


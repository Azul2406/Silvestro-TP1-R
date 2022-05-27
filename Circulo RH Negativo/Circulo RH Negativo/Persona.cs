using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Circulo_RH_Negativo
{
    public class Persona
    {

        //protected long dni;
        //protected string nombre, apellido, domicilio, localidad, email,
        //                    grupoSanguineo, tipoMedicacion;
        //protected DateTime fechaNacimiento;
        //protected bool medicacion;


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Email { get /*{ return email; }*/; set /*{Validaciones.email_bien_escrito(email)}*/ ; }
        public string TipoMedicacion { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Medicacion { get; set; }
        public string Categoria { get; set; }
        public int CantidadDonacionesUltimoAño { get; set; }

        public Persona()
        {

        }



        public static List<Persona> personasAsociadas = new List<Persona>()
        {
             new Persona() { Nombre = "Pedro", Apellido = "Pedrini", FechaNacimiento = new DateTime(99,11,11), Dni = "33333333", Domicilio = "San Juan 123",
                                        Localidad = "Santa Fe", Email = "aaa@aaa.aaa", GrupoSanguineo = "AB+", Medicacion = false, TipoMedicacion = "",CantidadDonacionesUltimoAño = 0, Categoria = "Activo" },
             new Persona() { Nombre = "Pablo", Apellido = "Pabli", FechaNacimiento = new DateTime(99,12,24), Dni = "33333333", Domicilio = "San Juan 123",
                                        Localidad = "Santa Fe", Email = "aaa@aaa.aaa", GrupoSanguineo = "A+", Medicacion = true, TipoMedicacion = "mmmm",CantidadDonacionesUltimoAño = 0, Categoria = "Pasivo"},
             new Persona() { Nombre = "Sandra", Apellido = "Sandrini", FechaNacimiento =new DateTime(01,01,01), Dni = "11111111", Domicilio = "San Luis 122",
                                        Localidad = "San Francisco", Email = "bbb@bbb.bbb", GrupoSanguineo = "A-", Medicacion = false, TipoMedicacion = "", CantidadDonacionesUltimoAño=1, Categoria = "Activo"},
             new Persona(){Nombre = "Alfonso", Apellido = "Alfonsini", FechaNacimiento =new DateTime(89,06,15), Dni = "6666666", Domicilio = "La Rioja 555" ,
                                        Localidad = "Clucellas", Email = "ppp@ppp.ppp", GrupoSanguineo = "A-", Medicacion = true, TipoMedicacion = "iiiii",CantidadDonacionesUltimoAño = 0, Categoria = "Pasivo"},
             new Persona(){Nombre = "Caterina", Apellido = "Caterina", FechaNacimiento =new DateTime(08,04,30), Dni = "77777777", Domicilio = "Peru 6",
                                        Localidad = "San Francisco", Email = "lll@lll.lll", GrupoSanguineo = "O+", Medicacion = false, TipoMedicacion = "", CantidadDonacionesUltimoAño = 2, Categoria = "Activo"}

         };






        public void NuevoAsociado()
        {
            string dni;
            string nombre, apellido, domicilio, localidad, email,
                            grupoSanguineo, tipoMedicacion;
            DateTime fechaNacimiento;
            bool medicacion;
            int cantidadDonacionesUltimoAño;
            string medic;

            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI: ");
            dni = Console.ReadLine();
            Console.WriteLine("Ingrese la localidad: ");
            localidad = Console.ReadLine();
            Console.WriteLine("Ingrese el domicilio: ");
            domicilio = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            email = Console.ReadLine();
            Console.WriteLine("Ingrese el año de nacimiento: ");
            string year = Console.ReadLine();
            Console.WriteLine("Ingrese el mes de nacimiento: ");
            string month = Console.ReadLine();
            Console.WriteLine("Ingrese el dia de nacimiento: ");
            string day = Console.ReadLine();
            fechaNacimiento = new DateTime(Int16.Parse(year), Int16.Parse(month), Int16.Parse(day));
            Console.WriteLine("Ingrese el grupo sanguineo (O- / O+ / A- / A+ / B- / B+ / AB- / AB+): ");
            grupoSanguineo = Console.ReadLine();
            Console.WriteLine("¿Toma alguna medicacion?: ");
            string linea = Console.ReadLine();
            if (linea.Equals("si"))
            {
                medicacion = true;
            }
            else
            {
                medicacion = false;
            }
            Console.WriteLine("Si toma medicacion, ingrese cual: ");
            tipoMedicacion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de donaciones que realizo en el ultimo año: ");
            linea = Console.ReadLine();
            cantidadDonacionesUltimoAño = int.Parse(linea);
            personasAsociadas.Add(new Persona() { Nombre = nombre, Apellido = apellido, FechaNacimiento = fechaNacimiento, Dni = dni, Domicilio = domicilio,
                Localidad = localidad, Email = email, GrupoSanguineo = grupoSanguineo, Medicacion = medicacion, TipoMedicacion = tipoMedicacion, CantidadDonacionesUltimoAño = cantidadDonacionesUltimoAño, Categoria = "" });


            foreach (Persona persona in personasAsociadas)
            {
                DefinirCategoria(FechaNacimiento, Medicacion);
            }

             if (medicacion == true)
             {
                 medic = "Si";
             }
             else { medic = "No"; }

            Console.WriteLine("Cliente ingresado con exito.");
            Console.WriteLine("Nombre: " + nombre + "\n Apellido: " + apellido + "\n Fecha de nacimiento: " + fechaNacimiento + "\n DNI: " + dni + "\n Domicilio: " + domicilio +
                                "\n Localidad: " + localidad + "\n Email: " + email + "\n Grupo Sanguineo: " + grupoSanguineo + "\n Medicacion: " +medic +
                                "\n Tipo de medicacion: " + tipoMedicacion + "\n Cantidad de donaciones del ultimo año: " + cantidadDonacionesUltimoAño);
        }

        public void DefinirCategoria(DateTime fecha, bool medicacion)
        {
            
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fecha.Year;
            if (fechaActual.Month < fecha.Month)
            {
                --edad;
            }
            else
            {
                if (fechaActual.Month == fecha.Month && fechaActual.Day > fecha.Day)
                {
                    --edad;
                }
            }

            if (edad >= 18 && edad <= 56 && medicacion == false)
            {
                this.Categoria = "Activo";
            }
            else
            {
                this.Categoria  = "Pasivo";
            }
            //Console.WriteLine("El asociado " + Nombre + " de " + edad + " pertenece a la categoria " + categoria);
        }
        Pedido pedidos = new Pedido();
        

        //public void MostrarLista()
        //{
        //    foreach (var persona in personasAsociadas)
        //    {
        //        Console.WriteLine(persona.Apellido);
        //    }
        //}
       
    }
}

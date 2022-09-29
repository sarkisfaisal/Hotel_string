using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class Modificaciones
    {
        //------------------------INICIO MODIFICAR ROL--------------------------
        public string modificar_rol() {
            bool fin = true;
            string respuestaFinal =  "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_roles();
                Console.WriteLine("Ingrese el id del rol a modificar");
                string idrol = Console.ReadLine();
                DataTable datos = new rol().TraerFila(idrol);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró un rol con ese Id");
                    Console.WriteLine("Pulse cualquier tecla para continuar");
                    Console.WriteLine("2. Salir");
                    string opcion = Console.ReadLine();
                    if (opcion == "2")
                    {
                        fin = false;
                        respuestaFinal = "";
                    }
                }
                else
                {
                    string descripcionAntigua = datos.Rows[1].ToString();
                    Console.WriteLine("Ingrese una nueva descripción para el rol que desea modificar");
                    string descripcionNueva = Console.ReadLine();
                    respuestaFinal = new rol(descripcionNueva).modificar(descripcionAntigua);
                }

            }
            return respuestaFinal;
        }
        //---------------------------FIN MOSTRAR ROL---------------------------------

        //----------------------INICIO MODIFICAR TIPO PAGO---------------------------
        public string modificar_tipo_pago()
        {
            bool fin = true;
            string respuestaFinal = "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_tipo_pago();
                Console.WriteLine("Ingrese el id del tipo de pago que desea modificar");
                string id = Console.ReadLine();
                DataTable datos = new tipo_pago("").TraerFila(id);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró un tipo de pago con esa descripción");
                    Console.WriteLine("Pulse cualquier tecla para continuar");
                    Console.WriteLine("2. Salir");
                    string opcion = Console.ReadLine();
                    if (opcion == "2")
                    {
                        fin = false;
                        respuestaFinal = "";
                    }
                }
                else
                {
                    string descripcionAntigua = datos.Rows[1].ToString();
                    Console.WriteLine("Ingrese una nueva descripción para el tipo de pago que desea modificar");
                    string descripcionNueva = Console.ReadLine();
                    respuestaFinal = new tipo_pago(descripcionNueva).modificar(descripcionAntigua);
                }

            }
            return respuestaFinal;
        }
        //------------------------FIN MODIFICAR ROL---------------------------------------

        //----------------------INICIO MODIFICAR HABITACIÓN-------------------------------

        //-----------------------FIN MODIFICAR HABITACIÓN---------------------------------

        //-----------------------INICIO MODIFICAR ORIGEN----------------------------------
        public string modificar_origen()
        {
            bool fin = true;
            string respuestaFinal = "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_origenes();
                Console.WriteLine("Ingrese el nombre del origen que desea modificar");
                string idorigen = Console.ReadLine();
                DataTable datos = new rol().TraerFila(idorigen);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró un origen con ese nombre");
                    Console.WriteLine("Pulse cualquier tecla para continuar");
                    Console.WriteLine("2. Salir");
                    string opcion = Console.ReadLine();
                    if (opcion == "2")
                    {
                        fin = false;
                        respuestaFinal = "";
                    }
                }
                else
                {
                    string nombreAntiguo = datos.Rows[1].ToString();
                    Console.WriteLine("Ingrese un nuevo nombre para el origen que desea modificar");
                    string nombreNuevo = Console.ReadLine();
                    respuestaFinal = new origen(nombreNuevo).modificar(nombreAntiguo);
                }

            }
            return respuestaFinal;
        }
        //------------------------FIN MODIFICAR ORIGEN------------------------------------

        //------------------------INICIO MODIFICAR TURNO----------------------------------
        public string modificar_turno()
        {
            bool fin = true;
            string respuestaFinal = "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_roles();
                Console.WriteLine("Ingrese el tipo de turno que desea modificar");
                string idrol = Console.ReadLine();
                DataTable datos = new rol().TraerFila(idrol);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró el tipo de turno ingresado");
                    Console.WriteLine("Pulse cualquier tecla para continuar");
                    Console.WriteLine("2. Salir");
                    string opcion = Console.ReadLine();
                    if (opcion == "2")
                    {
                        fin = false;
                        respuestaFinal = "";
                    }
                }
                else
                {
                    string descripcionAntigua = datos.Rows[1].ToString();
                    Console.WriteLine("Ingrese una descripción para el turno a modificar");
                    string descripcionNueva = Console.ReadLine();
                    respuestaFinal = new turno (descripcionNueva).modificar(descripcionAntigua);
                }

            }
            return respuestaFinal;
        }
        //-------------------------FIN MODIFICAR TURNO------------------------------------
    }
}
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
                    string descripcionAntigua = "";
                    foreach (DataRow fila in datos.Rows)
                    {
                        //Se obtiene la descripcion antigua del rol a modificar
                        descripcionAntigua = fila[1].ToString();
                    }
                    Console.WriteLine("Ingrese una nueva descripción para el rol que desea modificar");
                    string descripcionNueva = Console.ReadLine();
                    string resp = new rol(descripcionNueva).modificar(descripcionAntigua);
                    respuestaFinal = resp;
                    fin = false;
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
                string idtipo_pago = Console.ReadLine();
                DataTable datos = new tipo_pago("").TraerFila(idtipo_pago);
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
                  int descripcionAntigua = 0;
                    foreach (DataRow fila in datos.Rows)
                    {
                        
                        descripcionAntigua = Convert.ToInt32(fila[0]);
                    }
                    Console.WriteLine("Ingrese una nueva descripción para el tipo de pago que desea modificar");
                    string descripcionNueva = Console.ReadLine();
                    string resp = new tipo_pago(descripcionNueva).modificar(descripcionAntigua);
                    respuestaFinal = resp;
                    fin = false;
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
                Console.WriteLine("Ingrese el id del origen que desea modificar");
               string idorigen = Console.ReadLine();
                DataTable datos = new origen().TraerFila(idorigen);
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
                    int nombreantiguo = 0; 
                    foreach (DataRow fila in datos.Rows)
                    {
                        nombreantiguo = Convert.ToInt32(fila[0]);
                    }
                    Console.WriteLine("Ingrese un nuevo nombre para el origen que desea modificar");
                    string nombreNuevo = Console.ReadLine();
                    string resp = new origen(nombreNuevo).modificar(nombreantiguo);
                    respuestaFinal = resp;
                    fin = false;
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
                new Muestras().mostrar_turno();
                Console.WriteLine("Ingrese el id del turno que desea modificar");
                string idturno = Console.ReadLine();
                DataTable datos = new turno().TraerFila(idturno);
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
                    int descripcionAntigua=0;
                    foreach (DataRow fila in datos.Rows)
                    {
                        descripcionAntigua = Convert.ToInt32(fila[0]);
                    }
                    Console.WriteLine("Ingrese una descripción para el turno a modificar");
                    string descripcionNueva = Console.ReadLine();
                    string resp = new turno (descripcionNueva).modificar(descripcionAntigua);
                    respuestaFinal = resp;
                    fin = false;
                }

            }
            return respuestaFinal;
        }
        //-------------------------FIN MODIFICAR TURNO------------------------------------

        //------------------------INICIO MODIFICAR PACK-----------------------------------
        public string modificar_pack()
        {
            bool fin = true;
            string respuestaFinal = "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_pack();
                Console.WriteLine("Ingrese el id del pack que desea modificar");
                string idpack = Console.ReadLine();
                DataTable datos = new pack().TraerFila(idpack);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró la descripcón del pack ingresado");
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
                    int descripcionAntigua=0;
                    foreach (DataRow fila in datos.Rows)
                    {
                       descripcionAntigua = Convert.ToInt32(fila[0]);
                    }
                    Console.WriteLine("Ingrese una descripción para el pack a modificar");
                    string descripcionNueva = Console.ReadLine();
                    string resp = new pack(descripcionNueva).modificar(descripcionAntigua);
                    respuestaFinal = resp;
                    fin = false;
                }

            }
            return respuestaFinal;
        }
        //-------------------------FIN MODIFICAR PACK-------------------------------------
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea2
{
    public class CadenasEnOrden
    {
        //Este es el ejercicio 5 del Capitulo 5
        public void MostrarCadenas()
        {
            Console.Clear();
            ArrayList array = new ArrayList();
            string cadena1, cadena2;
            try
            {
                Console.Write("Ingrese una cadena:");
                cadena1 = Console.ReadLine();
                array.Add(cadena1);
                Console.Write("Ingrese la siguiente cadena:");
                cadena2 = Console.ReadLine();
                array.Add(cadena2);
                Console.WriteLine("Las Cadenas Ordenadas son:\n\n ");

                array.Sort();
                foreach (String cadena in array)
                {
                    Console.WriteLine("{0}", cadena);
                }
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }
        }
    }
}

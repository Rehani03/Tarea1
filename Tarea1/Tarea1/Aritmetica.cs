using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea1
{

    public class Aritmetica
    {
        
        private const int MAX = 10;
        
        public void mostrarTablasMultiplicacion()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese numero:");
                string dato = Console.ReadLine();
                double numero1 = Convert.ToDouble(dato);
                Console.Write("La tabla de multiplicacion del 1 al 10 del numero " + numero1 + " es:\n");
                for (int i = 0; i <= MAX; i++)
                {
                    Console.WriteLine(i + "*" + numero1 + "=" + (numero1 * i));
                }
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }
        }

        public void potencia()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese la base:");
                string ba = Console.ReadLine();
                double datoBase = Convert.ToDouble(ba);

                Console.Write("Ingrese el exponente:");
                string exp = Console.ReadLine();
                double exponente = Convert.ToDouble(exp);
                Console.WriteLine("La Potencia es:" + Math.Round(Math.Pow(datoBase, exponente), 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error "+ error);
            }
        }

        public void promedioEdad()
        {
            double acumEdad = 0;
            int MAX = 0;
            int MIN = 9999999;
            try
            {
                Console.Clear();
                Console.Write("Cuantas Personas hay? :");
                string dato = Console.ReadLine();
                int numeroPersonas = Convert.ToInt32(dato);
                for(int i=0; i<numeroPersonas; i++)
                {
                    Console.Write("\nEdad de Persona "+(i + 1) +" es:");
                    string aux = Console.ReadLine();
                    int edad = Convert.ToInt32(aux);
                    if (edad > MAX)
                        MAX = edad;
                    if (edad < MIN)
                        MIN = edad;
                    acumEdad += edad;
                }
                double promedio = Math.Round((acumEdad / numeroPersonas), 2);
                Console.WriteLine("El promedio de edad es:" +promedio);
                Console.WriteLine("La edad mas alta es:" +MAX);
                Console.WriteLine("La edad mas pequeña es:" +MIN);
                Console.ReadKey();

            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
        }

        public void NumeroParImpar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese un numero:");
                string dato = Console.ReadLine();
                int num = Convert.ToInt32(dato);
                if (num % 2 == 0)
                    Console.WriteLine("Es un numero par");
                else
                    Console.WriteLine("Es un numero impar");
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error " + error);
                
            }
        }
    }
}

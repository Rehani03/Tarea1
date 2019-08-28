using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea1
{
    public class DiadeSemana
    {
        public void diasSemana()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero del 1 al 7 para ver el dia de la semana");
                Console.Write("Dia:");
                string d = Console.ReadLine();
                int dia = Convert.ToInt32(d);
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Este dia es: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Este dia es: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Este dia es: Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Este dia es: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Este dia es: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Este dia es: Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Este dia es: Domingo");
                        break;
                    default:
                        Console.WriteLine("No existe ese dia...");
                        break;
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

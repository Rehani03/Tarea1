using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea1
{
    public class ConversorTemperaturaGrados
    {
        private int grados;
        private string dato;
        public void convertirGradosRadeanes()
        {
            try
            {
                Console.Clear();
                Console.Write("Grados:");
                dato = Console.ReadLine();
                grados = Convert.ToInt32(dato);
                double resultado = Math.Round(grados * Math.PI / 180, 2);
                Console.WriteLine("En Radeanes son:" + resultado);
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error" + error);
            }
            
        }

        public void convertirCelciusFarenheit()
        {
            try
            {
                Console.Clear();
                Console.Write("Celcius:");
                dato = Console.ReadLine();
                grados = Convert.ToInt32(dato);
                double resultado = Math.Round(grados*1.8 +32, 2);
                Console.WriteLine("En Farenheit son:" + resultado);
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error" + error);
            }
        }
    }
}

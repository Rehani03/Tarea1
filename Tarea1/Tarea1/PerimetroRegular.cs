using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Tarea1
{
    public class PerimetroRegular
    {
        public void perimetroRegularFiguras()
        {
            try
            {
                Console.Clear();
                int numLados;
                double longitudLado;
                string ladoS, longS;
                Console.WriteLine("Numero de Lados:");
                ladoS = Console.ReadLine();
                numLados = Convert.ToInt32(ladoS);
                Console.WriteLine("Tamaño de Lados:");
                longS = Console.ReadLine();
                longitudLado = Convert.ToDouble(longS);

                double perimetro = Math.Round(numLados * longitudLado,2);
                Console.WriteLine("El perimetro es:" + perimetro);
                Console.ReadKey();

            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }

        }
    }
}

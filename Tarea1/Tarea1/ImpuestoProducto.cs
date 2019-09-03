using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea1
{
    public class ImpuestoProducto
    {
        private const double impuestoMedicina = 0;
        private const double impuestoGenerico = 0.18;
        public void impuestoProducto()
        {
          
            double impuesto = 0.0;
            try
            {
                Console.Clear();
                Console.WriteLine("Nombre del Producto:");
                string nomProducto = Console.ReadLine();
                Console.WriteLine("Precio del Producto:");
                string nomPrecio = Console.ReadLine();
                double precio = Convert.ToDouble(nomPrecio);
                Console.WriteLine("1. Es Medicina o 2. Producto Generico\n");
                Console.Write("Opcion:");
                string dato = Console.ReadLine();
                int opcion = Convert.ToInt32(dato);

                switch (opcion)
                {
                    case 1:
                        impuesto = impuestoMedicina ;
                        Console.WriteLine("El producto " + nomProducto + " no tiene impuesto:" + Math.Round(impuesto, 2));
                        break;
                    case 2:
                        impuesto = precio * impuestoGenerico;
                        Console.WriteLine("El producto " + nomProducto + "tiene impuesto:" + Math.Round(impuesto, 2));
                        break;
                    default:
                        Console.WriteLine("No existe esa opcion");
                        break;
                }

                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
        }
    }
}

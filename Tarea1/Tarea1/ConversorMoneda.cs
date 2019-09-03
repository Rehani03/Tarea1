using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea1
{
   
    public class ConversorMoneda
    {
        private double dolarDia;
        private double euroDia;
        private string dolarS;
        private string euroS;
        private double cantidad;
        private string cantidadS;
        public void convertirDolarEuro()
        {
            try
            {
                Console.Clear();
                Console.Write("Dolar Al Dia:");
                dolarS = Console.ReadLine();
                dolarDia = Convert.ToDouble(dolarS);
                Console.Write("\nEuro Al Dia:");
                euroS = Console.ReadLine();
                euroDia = Convert.ToDouble(euroS);
                Console.Write("\nCantidad a Cambiar:");
                cantidadS = Console.ReadLine();
                cantidad = Convert.ToDouble(cantidadS);
                double cambioDolar = cantidad * dolarDia;
                double cambioEuro = cantidad * euroDia;
                double valorDolarvsEuro = Math.Round(dolarDia / euroDia, 2);
                double valorEurovsDolar = Math.Round(euroDia / dolarDia, 2);

                Console.WriteLine("Cambio Dolar:" + cambioDolar);
                Console.WriteLine("Cambio Euro:" + cambioEuro);
                Console.WriteLine("Valor de Dolar vs Euro:" + valorDolarvsEuro);
                Console.WriteLine("Valor de Euro vs Dolar:" + valorEurovsDolar);
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, opcionMoneda, opcionCondicion;
            string dato, datoMoneda, datoCondicion;
            int opcionMenuInicial;
            string datoMenuInicial;

            Tarea1.ImprimirNombres oraciones = new Tarea1.ImprimirNombres();
            Tarea1.ConversorTemperaturaGrados t = new Tarea1.ConversorTemperaturaGrados();
            Tarea1.ConversorMoneda moneda = new Tarea1.ConversorMoneda();
            Tarea1.PerimetroRegular perimetro = new Tarea1.PerimetroRegular();

            do
            {
                Console.Clear();
                Console.WriteLine("     .:Menu:.\n"     );
                Console.WriteLine("1. Capitulo 1");
                Console.WriteLine("2. Capitulo 2");
                Console.WriteLine("3. Capitulo 3");
                Console.WriteLine("4. Capitulo 4");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion:");
                datoMenuInicial = Console.ReadLine();
                opcionMenuInicial = Convert.ToInt32(datoMenuInicial);
     
                switch (opcionMenuInicial)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Ver Ejercicio 1");
                            Console.WriteLine("2. Ver Ejercicio 2");
                            Console.WriteLine("3. Salir");
                            Console.Write("Opcion:");
                            dato = Console.ReadLine();
                            opcion = Convert.ToInt32(dato);
                            switch (opcion)
                            {
                                case 1:
                                    oraciones.imprimirNombre();
                                     break;
                                case 2:
                                    oraciones.imprimirCadenas();
                                    break;
                                case 3:
                                    
                                    break;
                                default:
                                    Console.WriteLine("Esta opcion no existe");
                                    break;
                            }
                        }
                        while (opcion != 3);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Calcular poligono Regular");
                            Console.WriteLine("2. Conversor de Grados a Radeanes");
                            Console.WriteLine("3. Conversor de Centrigrados a Farehenit");
                            Console.WriteLine("4. Conversor de Monedas");
                            Console.WriteLine("5. Salir");
                            Console.Write("Opcion:");
                            datoMoneda = Console.ReadLine();
                            opcionMoneda = Convert.ToInt32(datoMoneda);

                            switch (opcionMoneda)
                            {
                                case 1:
                                    perimetro.perimetroRegularFiguras();
                                    break;
                                case 2:
                                    t.convertirGradosRadeanes();
                                    break;
                                case 3:
                                    t.convertirCelciusFarenheit();
                                    break;
                                case 4:
                                    moneda.convertirDolarEuro();
                                    break;
                                case 5:

                                    break;
                                default:
                                    Console.WriteLine("Opcion no existe");
                                    break;
                            }
                        }
                        while (opcionMoneda != 5);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Calcular numero par o Impar");
                            Console.WriteLine("2. Dia de la semana");
                            Console.WriteLine("3. Calcular Perimetro y Area de un Poligono Regular");
                            Console.WriteLine("4. Salir");
                            Console.WriteLine("Opcion:");
                            datoCondicion = Console.ReadLine();
                            opcionCondicion = Convert.ToInt32(datoCondicion);
                            switch (opcionCondicion)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("No existe esa opcion");
                                    break;
                            }
                        }
                        while (opcionCondicion != 4);
                        break;
                    default:
                        Console.WriteLine("Esta opcion no existe");
                        break;
                }
            }
            while (opcionMenuInicial != 5);
        }
    }
}

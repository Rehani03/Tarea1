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
            menu();
        }

        private static void menu()
        {
                int opcion, opcionMoneda, opcionCondicion, opcionCiclo;
                string dato, datoMoneda, datoCondicion, datoCiclo;
                int opcionMenuInicial;
                string datoMenuInicial;

                Tarea1.ImprimirNombres oraciones = new Tarea1.ImprimirNombres();
                Tarea1.ConversorTemperaturaGrados t = new Tarea1.ConversorTemperaturaGrados();
                Tarea1.ConversorMoneda moneda = new Tarea1.ConversorMoneda();
                Tarea1.PerimetroRegular perimetro = new Tarea1.PerimetroRegular();
                Tarea1.Aritmetica aritmetica = new Tarea1.Aritmetica();
                Tarea1.ImpuestoProducto impuesto = new Tarea1.ImpuestoProducto();
                Tarea1.DiadeSemana semana = new Tarea1.DiadeSemana();
                Tarea1.PoligonosRegulares poligonos = new Tarea1.PoligonosRegulares();

                do
                {
                    Console.Clear();
                    Console.WriteLine(".............::Rehani Cordero 2017-0302::............\n");
                    Console.WriteLine("     .:Menu:.\n");
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
                                Console.WriteLine("1. Mi nombre ");
                                Console.WriteLine("2. Varias cadenas 2");
                                Console.WriteLine("3. Atras");
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
                                Console.WriteLine("5. Atras");
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
                                Console.WriteLine("2. Impuesto de un producto");
                                Console.WriteLine("3. Dia de la semana");
                                Console.WriteLine("4. Calcular Perimetro y Area de un Poligono Regular");
                                Console.WriteLine("5. Atras");
                                Console.WriteLine("Opcion:");
                                datoCondicion = Console.ReadLine();
                                opcionCondicion = Convert.ToInt32(datoCondicion);
                                switch (opcionCondicion)
                                {
                                    case 1:
                                        aritmetica.NumeroParImpar();
                                        break;
                                    case 2:
                                        impuesto.impuestoProducto();
                                        break;
                                    case 3:
                                        semana.diasSemana();
                                        break;
                                    case 4:
                                        poligonos.AreaPerimetroRegular();
                                        break;
                                    case 5:

                                        break;
                                    default:
                                        Console.WriteLine("No existe esa opcion");
                                        break;
                                }
                            }
                            while (opcionCondicion != 5);
                            break;
                        case 4:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1. Tabla de Multiplicar");
                                Console.WriteLine("2. Potencia de un numero");
                                Console.WriteLine("3. Promedio de edades");
                                Console.WriteLine("4. Atras\n");
                                Console.Write("Opcion:");
                                datoCiclo = Console.ReadLine();
                                opcionCiclo = Convert.ToInt32(datoCiclo);

                                switch (opcionCiclo)
                                {
                                    case 1:
                                        aritmetica.mostrarTablasMultiplicacion();
                                        break;
                                    case 2:
                                        aritmetica.potencia();
                                        break;
                                    case 3:
                                        aritmetica.promedioEdad();
                                        break;
                                    case 4:

                                        break;
                                    default:
                                        Console.WriteLine("Esa opcion no existe");
                                        break;
                                }
                            }
                            while (opcionCiclo != 4);
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


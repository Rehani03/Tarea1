using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuTarea2();
        }

        private static void MenuTarea1()
        {
                int opcion, opcionMoneda, opcionCondicion, opcionCiclo;
                string dato, datoMoneda, datoCondicion, datoCiclo;
                int opcionMenuInicial;
                string datoMenuInicial;

                Tareas.Tarea1.ImprimirNombres oraciones = new Tareas.Tarea1.ImprimirNombres();
                Tareas.Tarea1.ConversorTemperaturaGrados t = new Tareas.Tarea1.ConversorTemperaturaGrados();
                Tareas.Tarea1.ConversorMoneda moneda = new Tareas.Tarea1.ConversorMoneda();
                Tareas.Tarea1.PerimetroRegular perimetro = new Tareas.Tarea1.PerimetroRegular();
                Tareas.Tarea1.Aritmetica aritmetica = new Tareas.Tarea1.Aritmetica();
                Tareas.Tarea1.ImpuestoProducto impuesto = new Tareas.Tarea1.ImpuestoProducto();
                Tareas.Tarea1.DiadeSemana semana = new Tareas.Tarea1.DiadeSemana();
                Tareas.Tarea1.PoligonosRegulares poligonos = new Tareas.Tarea1.PoligonosRegulares();

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

        private static void MenuTarea2()
        {
           int opcion=0, numero;
           const int PROMEDIO = 1, MAYOR = 2, MENOR = 3, JAGGED = 4;

            Tareas.Tarea2.Factorial factorialNumero = new Tareas.Tarea2.Factorial();
            Tareas.Tarea2.DeNumeroALetras convertir = new Tareas.Tarea2.DeNumeroALetras();
            Tareas.Tarea2.ArregloDeEstudianteJagged arreglosEstudiante = new Tareas.Tarea2.ArregloDeEstudianteJagged();
            Tareas.Tarea2.PromedioArrayList promedio = new Tareas.Tarea2.PromedioArrayList();
            Tareas.Tarea2.DiccionarioPalabras diccionario = new Tareas.Tarea2.DiccionarioPalabras();
            Tareas.Tarea2.AgendaHash agendaNueva = new Tareas.Tarea2.AgendaHash();
            Tareas.Tarea2.FormatoFecha fecha = new Tareas.Tarea2.FormatoFecha();
            Tareas.Tarea2.CadenasEnOrden ordenCadena = new Tareas.Tarea2.CadenasEnOrden();

            do
            {
                try
                {


                    Console.Clear();

                    Console.WriteLine("                     Programacion Aplicada I");
                    Console.WriteLine("                           Tarea 2");
                    Console.WriteLine("                    Rehani Cordero 2017-0302\n\n");
                    Console.WriteLine("1. Calcular Factorial de un numero");
                    Console.WriteLine("2. Ingresar un numero en digitos e imprimirlo en letras");
                    Console.WriteLine("3. Calcular Promedio de arreglo Jagged");
                    Console.WriteLine("4. Calcular Mayor Calificacion de arreglo Jagged");
                    Console.WriteLine("5. Calcular Menor Calificacion de arreglo Jagged");
                    Console.WriteLine("6. Programa que pasa un arreglo Jagged a una funcion");
                    Console.WriteLine("7. Calcular Promedio de Calificaciones de un Salon de Clase en ArrayList");
                    Console.WriteLine("8. Diccionario de Palabras en HashTable");
                    Console.WriteLine("9. Agenda de Contactos en HashTable");
                    Console.WriteLine("10.Programa que muestra la fecha y hora en formato AM/PM");
                    Console.WriteLine("11.Programa que muestra dos cadenas en orden alfabetico");
                    Console.WriteLine("12. Salir");
                    Console.Write("Opcion:");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese un numero:");
                            numero = Convert.ToInt32(Console.ReadLine());
                            factorialNumero.calcularFactorial(numero);
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Ingrese el numero a convertir:");
                            numero = Convert.ToInt32(Console.ReadLine());
                            convertir.ConvertirNumeros(numero);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(PROMEDIO);
                            break;
                        case 4:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(MAYOR);
                            break;
                        case 5:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(MENOR);
                            break;
                        case 6:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(JAGGED);
                            break;
                        case 7:
                            promedio.CalcularPromedioArrayList();
                            break;
                        case 8:
                            diccionario.DiccionarioHash();
                            break;
                        case 9:
                            agendaNueva.agenda();
                            break;
                        case 10:
                            fecha.MostrarFechaHora();
                            break;
                        case 11:
                            ordenCadena.MostrarCadenas();
                            break;
                        case 12:
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Esta opcion no existe");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error " + error);
                    Console.ReadKey();
                }
            }
            while (opcion != 12);
        
        }
    }
}


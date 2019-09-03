using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea1
{
    public class PoligonosRegulares
    {
        private const int NUMLADOSEQUILATERO = 3;
        private const int NUMLADOSCUADRADO = 4;
        private const int NUMLADOSPENTAGONO = 5;
        private const int NUMLADOSHEXAGONO = 6;
        private const int NUMLADOSHEPTAGONO = 7;
        private const int NUMLADOSOCTAGONO = 8;
        private double area, perimetro;

        public void AreaPerimetroRegular()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion...");
                Console.WriteLine("1 Triangulo Equilatero");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Pentagono regular");
                Console.WriteLine("4. Hexagono regular");
                Console.WriteLine("5. Heptagono regular");
                Console.WriteLine("6. Octagono regular");
                Console.WriteLine("7. Atras");
                Console.Write("Opcion:");
                string dato = Console.ReadLine();
                int opcion = Convert.ToInt32(dato);

                switch (opcion)
                {
                    case 1:
                        TrianguloEquilatero();
                        break;
                    case 2:
                        cuadrado();
                        break;
                    case 3:
                        pentagonoRegular();
                        break;
                    case 4:
                        HexagonoRegular();
                        break;
                    case 5:
                        HeptagonoRegular();
                        break;
                    case 6:
                        OctagonoRegular();
                        break;
                    case 7:

                        break;
                    default:
                        Console.WriteLine("Esta opcion no existe");
                        break;
                }
            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
        }

        private void TrianguloEquilatero()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                perimetro = longitud * NUMLADOSEQUILATERO;
                area = (Math.Sqrt(3) / 4) * Math.Pow(longitud, 2);
                Console.WriteLine("El perimetro de Triangulo Equilatero es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Triangulo Equilatero es:" + Math.Round(area,2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
            
        }

        private void cuadrado()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                 perimetro = longitud * NUMLADOSCUADRADO;
                 area = Math.Pow(longitud, 2);
                Console.WriteLine("El perimetro de Cuadrado es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Cuadrado es:" + Math.Round(area, 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
        }

        private void pentagonoRegular()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                Console.Write("\nApotema de la figura:");
                string apotemaDato = Console.ReadLine();
                double apotema = Convert.ToDouble(apotemaDato);
                perimetro = longitud * NUMLADOSPENTAGONO;
                 area = (NUMLADOSPENTAGONO * longitud * apotema) / 2;
                Console.WriteLine("El perimetro de Pentagono Regular es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Pentagono Regular es:" + Math.Round(area, 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error" + error);
            }
        }

        private void HexagonoRegular()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                Console.Write("\nApotema de la figura:");
                string apotemaDato = Console.ReadLine();
                double apotema = Convert.ToDouble(apotemaDato);
                perimetro = longitud * NUMLADOSHEXAGONO;
                area = 3 * longitud * apotema;
                Console.WriteLine("El perimetro de Hexagono Regular es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Hexagono Regular es:" + Math.Round(area, 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }

        }

        private void HeptagonoRegular()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                Console.Write("\nApotema de la figura:");
                string apotemaDato = Console.ReadLine();
                double apotema = Convert.ToDouble(apotemaDato);
                perimetro = longitud * NUMLADOSHEPTAGONO;
                area = (7 * longitud * apotema) / 2;
                Console.WriteLine("El perimetro de Heptagono Regular es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Heptagono Regular es:" + Math.Round(area, 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }

        }

        private void OctagonoRegular()
        {
            try
            {
                Console.Clear();
                Console.Write("Longitud de uno de los lados:");
                string longitudDato = Console.ReadLine();
                double longitud = Convert.ToDouble(longitudDato);
                Console.Write("\nApotema de la figura:");
                string apotemaDato = Console.ReadLine();
                double apotema = Convert.ToDouble(apotemaDato);
                perimetro = longitud * NUMLADOSOCTAGONO;
                area = 4 * longitud * apotema;
                Console.WriteLine("El perimetro de Octagono Regular es:" + Math.Round(perimetro, 2));
                Console.WriteLine("El area del Octagono Regular es:" + Math.Round(area, 2));
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
            }
        }
    }
}

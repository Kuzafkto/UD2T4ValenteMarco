using System;

namespace UD2T4ValenteMarco
{
    ///////////////////////////////////////////
    // Tarea: UD2T4
    // Alumno/a: Marco Valente
    // Curso: 2023/2024
    ///////////////////////////////////////////

    internal class Program
    {
        static void Main(string[] args)
        {
            bool skip = false; // Bandera para controlar si se debe omitir la entrada del usuario
            int option = -1;   // Opción elegida por el usuario
            float ladoP, ladoS, ladoT;  // Variables para almacenar longitudes de lados

            ConsoleKeyInfo key; // Tecla utilizada para confirmar cuando el usuario presiona INTRO

            do
            {
                if (!skip)
                {
                    Console.Clear();
                    Console.WriteLine("- MENÚ PRINCIPAL -\n0 - Salir\n1 - Rectángulo\n2 - Círculo\n3 - Triángulo\nIntroduzca su opción: ");
                    try
                    {
                        option = int.Parse(Console.ReadLine()); // Lee la opción del usuario

                    }
                    catch (FormatException)
                    {
                        option = -1;  // Si hay un error al convertir la entrada a int, establece la opción en -1
                        Console.Clear();
                    }
                }

                switch (option)
                {
                    case 1:
                        try
                        {
                            do
                            {
                                Console.Write("Ingrese el primer lado del rectángulo: ");
                                ladoP = float.Parse(Console.ReadLine());
                            } while (ladoP <= 0f);

                            do
                            {
                                Console.Write("Ingrese el segundo lado del rectángulo: ");
                                ladoS = float.Parse(Console.ReadLine());
                            } while (ladoS <= 0f);

                            Rectangulo rectangulo = new Rectangulo(ladoP, ladoS);
                            Console.WriteLine("Perímetro (circunferencia) del rectangulo: " + rectangulo.Perimetro());
                            Console.WriteLine("Área del rectangulo: " + rectangulo.Area());
                            Console.WriteLine("Introduzca INTRO para continuar");
                            key = Console.ReadKey();
                            while (key.Key != ConsoleKey.Enter)
                            {
                                key = Console.ReadKey();
                            }
                            Console.Clear();
                            skip = false;
                        }
                        catch (FormatException)
                        {
                            skip = true;  // Si hay un error al convertir la entrada a float, establece skip en true
                        }
                        break;

                    case 2:
                        try
                        {
                            float radio = 0;
                            do
                            {
                                Console.Write("Introduce el radio del círculo: ");
                                radio = float.Parse(Console.ReadLine());
                            } while (radio < 0);

                            Circulo circulo = new Circulo(radio);

                            Console.WriteLine("Perimetro del circulo: " + circulo.Perimetro());
                            Console.WriteLine("Área del círculo: " + circulo.Area());
                            Console.WriteLine("Introduzca INTRO para continuar");
                            key = Console.ReadKey();
                            while (key.Key != ConsoleKey.Enter)
                            {
                                key = Console.ReadKey();
                            }
                            key = Console.ReadKey();
                            while (key.Key != ConsoleKey.Enter)
                            {
                                key = Console.ReadKey();
                            }
                            Console.Clear();
                            skip = false;
                        }
                        catch (FormatException)
                        {
                            skip = true;
                        }
                        break;

                    case 3:
                        try
                        {
                            do
                            {
                                Console.Write("Ingrese la base del triángulo: ");
                                ladoP = float.Parse(Console.ReadLine());
                            } while (ladoP <= 0);

                            do
                            {
                                Console.Write("Ingrese la altura del triángulo: ");
                                ladoS = float.Parse(Console.ReadLine());
                            } while (ladoS <= 0);

                            Triangulo triangulo = new Triangulo(ladoP, ladoS);
                            Console.WriteLine("Perímetro (circunferencia) del triangulo: " + triangulo.Perimetro());
                            Console.WriteLine("Área del triangulo: " + triangulo.Area());
                            Console.WriteLine("Introduzca INTRO para continuar");
                            key = Console.ReadKey();
                            while (key.Key != ConsoleKey.Enter)
                            {
                                key = Console.ReadKey();
                            }
                            key = Console.ReadKey();
                            while (key.Key != ConsoleKey.Enter)
                            {
                                key = Console.ReadKey();
                            }
                            Console.Clear();
                            skip = false;
                        }
                        catch (FormatException)
                        {
                            skip = true;
                        }
                        break;
                }

            } while (option != 0);  // Continúa ejecutándose hasta que el usuario elija salir (opción 0)
        }
    }
}

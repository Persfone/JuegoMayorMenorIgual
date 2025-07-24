using System;

namespace jMayorMenorIgual
{
    class Program
    {
        static void Main()
        {
            Mazo mazo = new Mazo();
            mazo.Mezclar(); // No requiere parámetro
            int puntos = 0;

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al juego Mayor, Menor o Igual!");

                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Reglas del Juego");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        mazo = new Mazo();
                        mazo.Mezclar();
                        mazo.Jugar();
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Reglas del Juego:");
                        Console.WriteLine("1. Se te mostrará una carta y debes adivinar si la siguiente será mayor, menor o igual.");
                        Console.WriteLine("2. Si aciertas, ganas un punto; si fallas, pierdes un punto.");
                        Console.WriteLine("3. El juego termina cuando no quedan cartas.");
                        Console.WriteLine("4. Tu puntuación se mostrará al final del juego.");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

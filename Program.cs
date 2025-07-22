using System;

namespace JuegoMayorMenorIgual
{
    class Program
    {
        static void Main()
        {
            Mazo mazo = new Mazo();
            mazo.Mezclar();
            int puntos = 0

            bool salir = false;
            while (!salir)
            {
                console.WriteLine("Bienvenido al juego Mayor, Menor o Igual!");

                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Reglas del Juego");
                Console.WriteLine("3. Salir");
                Console.Write("\n\nSeleccione una opción: ");

                string opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Mazo.Jugar(mazo);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        console.WriteLine("Reglas del Juego: ");
                        console.WriteLine("1. Se te mostrará una carta y debes adivinar si la siguiente será mayor, menor o igual.");
                        console.WriteLine("2. Si aciertas, ganas un punto; si fallas, pierdes un punto.");
                        console.WriteLine("3. El juego termina cuando no quedan cartas o decides salir.");
                        console.WriteLine("4. Tu puntuación se mostrará al final del juego.");
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        salir = true;
                        break
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace jMayorMenorIgual
{
    public class Mazo
    {
        public List<Cartas> Cartas { get; set; }

        public Mazo()
        {
            Cartas = new List<Cartas>();
            string[] palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };
            for (int i = 1; i <= 13; i++)
            {
                foreach (var palo in palos)
                {
                    Cartas.Add(new Cartas(i, palo));
                }
            }
        }

        public void Mezclar()
        {
            Random rand = new Random();
            Cartas = Cartas.OrderBy(c => rand.Next()).ToList();
        }

        public void Jugar()
        {
            int puntos = 0;

            while (Cartas.Count >= 2)
            {
                Console.Clear();
                Cartas cartaActual = Cartas[0];
                Cartas.RemoveAt(0);
                Console.WriteLine($"Carta actual: {cartaActual.Valor} de {cartaActual.Palo}");

                Console.Write("¿La siguiente carta será mayor, menor o igual? (<, >, =): ");
                string respuesta = Console.ReadLine().Trim();

                Cartas siguienteCarta = Cartas[0];
                Cartas.RemoveAt(0);

                if ((respuesta == "<" && siguienteCarta.Valor < cartaActual.Valor) ||
                    (respuesta == ">" && siguienteCarta.Valor > cartaActual.Valor) ||
                    (respuesta == "=" && siguienteCarta.Valor == cartaActual.Valor))
                {
                    puntos++;
                    Console.WriteLine("¡Correcto! Ganaste un punto.");
                }
                else
                {
                    puntos--;
                    Console.WriteLine("Incorrecto. Perdiste un punto.");
                }

                Console.WriteLine($"La siguiente carta era: {siguienteCarta.Valor} de {siguienteCarta.Palo}");
                Console.WriteLine($"Puntos actuales: {puntos}");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            Console.WriteLine("\nEl juego ha terminado. No quedan más cartas.");
            Console.WriteLine($"Tu puntuación final es: {puntos}");
            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}

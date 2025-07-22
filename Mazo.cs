namespace JuegoMayorMenorIgual
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
        public void Mezclar(Mazo mazo)
        {
            Random rand = new Random();
            mazo.Cartas = mazo.Cartas.OrderBy(c => rand.Next()).ToList();
        }
        publilc void Jugar(Mazo mazo)
        {
            int puntos = 0;
            while (mazo.Cartas.Count > 0)
            {
                Console.Clear();
                Cartas cartaActual = mazo.Cartas[0];
                mazo.Cartas.RemoveAt(0);
                Console.WriteLine($"Carta actual: {cartaActual.Rango} de {cartaActual.Palo}");

                Console.WriteLine("¿La siguiente carta será mayor, menor o igual? (<, >, =): ");
                string respuesta = Console.ReadLine().Trim().ToLower();

                Cartas siguienteCarta = mazo.Cartas[0];
                mazo.Cartas.RemoveAt(0);

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
                Console.WriteLine($"La carta era: {siguienteCarta.Valor} de {siguienteCarta.Palo}");
                Console.WriteLine($"Puntos actuales: {puntos}");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            Console.WriteLine("El juego ha terminado. No quedan más cartas.");
            Console.WriteLine($"Tu puntuación final es: {puntos}");
            Console.WriteLine("Gracias por jugar!");
        }
    }
}
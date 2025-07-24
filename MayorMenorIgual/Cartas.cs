namespace jMayorMenorIgual
{
    public class Cartas
    {
        public int Valor { get; set; }
        public string Palo { get; set; }

        public Cartas(int valor, string palo)
        {
            Valor = valor;
            Palo = palo;
        }
    }
}

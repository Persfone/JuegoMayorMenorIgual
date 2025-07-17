using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;
    private Random rng;

    public Deck()
    {
        cards = new List<Card>();
        rng = new Random();
        InitializeDeck();
    }

    private void InitializeDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                cards.Add(new Card(suit, value));
            }
        }
    }

    public void Shuffle()
    {
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }

    public Card Deal()
    {
        if (cards.Count == 0)
        {
            Console.WriteLine("El mazo está vacío.");
            return null;
        }
        Card card = cards[cards.Count - 1];
        cards.RemoveAt(cards.Count - 1);
        return card;
    }

    public void Reset()
    {
        cards.Clear();
        InitializeDeck();
    }

    public int CardsRemaining()
    {
        return cards.Count;
    }
}
public Card(Suit suit, Value value)
{
    Suit = suit;
    Value = value;
}

public override string ToString()
{
    string suitString = Suit switch
    {
        Suit.Hearts => "Corazones",
        Suit.Diamonds => "Diamantes",
        Suit.Clubs => "Tréboles",
        Suit.Spades => "Picas",
        _ => throw new ArgumentOutOfRangeException()
    };
    return $"{Value} de {suitString}";
}
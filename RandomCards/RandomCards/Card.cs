namespace RandomCards
{
    internal class Card
    {
        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public string Name { get { return Value + " of " + Suit; } }

        public override string ToString()
        {
            return Name;
        }
    }
}

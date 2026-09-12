namespace RandomCards
{
    internal class Program
    {
        static void Main()
        {
            List<Card> cards = new List<Card>();
            Random random = new Random();

            Console.WriteLine("Antes:");
            
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Values)random.Next(1, 14), (Suits)random.Next(4)));
                Console.WriteLine(cards[i].Name);
            }

            cards.Sort(new CardComparer_byValue());

            Console.WriteLine("Depois:");

            foreach (Card card in cards)
                Console.WriteLine(card);

            Console.ReadKey();
        }
    }
}
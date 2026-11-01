namespace CowCalculator
{
    internal class Farmer
    {
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        public int BagsOfFeed { get; private set; }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}

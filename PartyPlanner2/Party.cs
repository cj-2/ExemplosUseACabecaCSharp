namespace PartyPlanner2
{
    internal abstract class Party
    {
        public Party(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
        }

        private const int CostOfFoodPerPerson = 25;
        private decimal CostOfDecoration = 0;
        private int _numberOfPeople;

        public virtual int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set { _numberOfPeople = value; }
        }

        private void CalculateCostOfDecorations(bool fancyDecorations)
        {
            CostOfDecoration = fancyDecorations ? (NumberOfPeople * 15M) + 50M : (NumberOfPeople * 7.5M) + 30M;
        }

        public virtual decimal CalculateCost(bool fancyDecorations)
        {
            CalculateCostOfDecorations(fancyDecorations);
            decimal cost = (CostOfFoodPerPerson * NumberOfPeople) + CostOfDecoration;
            if (NumberOfPeople > 12) cost += 100M;
            return cost;
        }
    }
}

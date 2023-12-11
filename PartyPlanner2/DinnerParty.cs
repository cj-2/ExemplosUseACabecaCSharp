namespace PartyPlanner2
{
    internal class DinnerParty : Party
    {

        public DinnerParty(int numberOfPeople, bool healtyOption): base(numberOfPeople)
        {
            SetHealthyOption(healtyOption);
        }

        private decimal CostOfBeveragesPerPerson;

        private void SetHealthyOption(bool healtyOption)
        {
            CostOfBeveragesPerPerson = healtyOption ? 5M : 20M;
        }

        // Sobrecarga, criando outro método com mais parâmetros.
        public decimal CalculateCost(bool fancyDecoration, bool healtyOption)
        {
            decimal cost = base.CalculateCost(fancyDecoration);
            cost += CostOfBeveragesPerPerson * NumberOfPeople;
            if (healtyOption) cost *= .95M;
            return cost;
        }
    }
}

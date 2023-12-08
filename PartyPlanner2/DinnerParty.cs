using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2
{
    internal class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations = false;
        private bool healtyOption = false;

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecoration = 0;

        public DinnerParty(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            SetOptions(numberOfPeople, healtyOption, fancyDecorations);
        }

        public void SetOptions(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            SetHealthyOption(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healtyOption)
        {
            this.healtyOption = healtyOption;
            CostOfBeveragesPerPerson = this.healtyOption ? 5M : 20M;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            CostOfDecoration = this.fancyDecorations ? (NumberOfPeople * 15M) + 50M : (NumberOfPeople * 7.5M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal cost = ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople) + CostOfDecoration;
            if (healtyOption) cost *= .95M;
            if (numberOfPeople > 12) cost += 100M;
            return cost;
        }
    }
}

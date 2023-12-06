using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyCalc
{
    internal class DinnerParty
    {
        private int NumberOfPeople;
        private const int CostOfFoodPerPerson = 25;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecoration = 0;
        private bool HealtyOption = false;

        public void SetPartyOptions(int people, bool fancy, bool healty)
        {
            NumberOfPeople = people;
            SetHealthyOption(healty);
            CalculateCostOfDecorations(fancy);
        }

        private void SetHealthyOption(bool healty)
        {
            HealtyOption = healty;
            CostOfBeveragesPerPerson = HealtyOption ? 5M : 20M;
        }

        private void CalculateCostOfDecorations(bool fancy)
        {
            CostOfDecoration = fancy ? (NumberOfPeople * 15M) + 50M : (NumberOfPeople * 7.5M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal cost = ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople) + CostOfDecoration;
            if (HealtyOption) cost *= .95M;
            return cost;
        }
    }
}

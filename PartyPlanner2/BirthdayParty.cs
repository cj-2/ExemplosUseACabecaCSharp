using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    internal class BirthdayParty
    {
        private const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations = false;

        public decimal CostOfDecoration = 0;
        public int CakeSize;

        private string cakeWriting = "";

        public string CakeWriting
        {
            get { return cakeWriting; }
            set
            {
                int maxLength = CakeSize == 8 ? 16 : 40;

                if (value.Length > maxLength) {
                    MessageBox.Show("To many letters for a " + CakeSize + "-inch cake", "Ops...");
                    cakeWriting = value.Substring(0, maxLength);
                }
                else { cakeWriting = value; }
            }
        }

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSizing();

                // Aqui é meio confuso, mas é preciso executar o set
                // sempre que o numerOfPeople muda, dessa forma
                // criando a segurança que caso o tamnho da festa
                // diminua, o bolo e consequentemente a mensagem escrita
                // também diminuirá.
                CakeWriting = cakeWriting; 
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            SetOptions(numberOfPeople, fancyDecoration, cakeWriting);
        }

        public void SetOptions(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            CalculateCakeSizing();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }
        private void CalculateCakeSizing()
        {
            if (numberOfPeople <= 4) CakeSize = 8;
            else CakeSize = 16;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            CostOfDecoration = this.fancyDecorations ? (NumberOfPeople * 15M) + 50M : (NumberOfPeople * 7.5M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal cost = (CostOfFoodPerPerson * NumberOfPeople) + CostOfDecoration;
            cost += CakeSize == 8 ? 40M : 75M;
            cost += CakeWriting.Length * .25M;
            if (numberOfPeople > 12) cost += 100M;
            return cost;
        }
    }
}

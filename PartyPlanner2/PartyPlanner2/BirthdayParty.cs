using System.Windows.Forms;

namespace PartyPlanner2
{
    internal class BirthdayParty : Party
    {
        public BirthdayParty(int numberOfPeople, string cakeWriting) : base(numberOfPeople)
        {
            CalculateCakeSizing();
            CakeWriting = cakeWriting;
        }

        private int CakeSize;
        private string cakeWriting = "";

        public string CakeWriting
        {
            get { return cakeWriting; }
            set
            {
                int maxLength = CakeSize == 8 ? 16 : 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("To many letters for a " + CakeSize + "-inch cake", "Ops...");
                    cakeWriting = value.Substring(0, maxLength);
                }
                else { cakeWriting = value; }
            }
        }

        override public int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSizing();
                CakeWriting = cakeWriting;
            }
        }

        private void CalculateCakeSizing()
        {
            if (NumberOfPeople <= 4) CakeSize = 8;
            else CakeSize = 16;
        }

        override public decimal CalculateCost(bool fancyDecoration)
        {
            decimal cost = base.CalculateCost(fancyDecoration);
            cost += CakeSize == 8 ? 40M : 75M;
            cost += CakeWriting.Length * .25M;
            return cost;
        }
    }
}

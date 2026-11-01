namespace QueenBee2
{
    internal class Bee
    {
        public Bee(int miligrams)
        {
            Miligrams = miligrams;
        }

        public virtual int ShiftsLeft { get { return 0; } }
        private int miligrams;

        public int Miligrams { get { return miligrams; } set { miligrams = value; } }

        public virtual double GetHoneyConsumption()
        {
            double honeyConsumption = ShiftsLeft > 0 ? ShiftsLeft + 9 : 7.5D;
            if (miligrams > 150) honeyConsumption *= 1.35;
            return honeyConsumption;
        }
    }
}

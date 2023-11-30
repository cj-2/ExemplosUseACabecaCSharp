using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2GuysAndMuchMoney
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (Cash >= amount && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I don't have enough cash to give you " + amount, Name + " says ");
                return 0;
            }
        }
        public int ReciveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " says...");
                return 0;
            }
        }
    }
}

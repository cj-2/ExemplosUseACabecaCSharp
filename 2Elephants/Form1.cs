using System;
using System.Windows.Forms;

namespace _2Elephants
{
    public partial class Form1 : Form
    {
        Elephant Lucinda;
        Elephant Lyod;
        public Form1()
        {
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Lyod = new Elephant() { Name = "Lyod", EarSize = 40 };
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lyod.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant elephantSwap = Lucinda;
            Lucinda = Lyod;
            Lyod = elephantSwap;

            MessageBox.Show("Objects swapped!");
        }
    }
}

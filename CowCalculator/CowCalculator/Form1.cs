using System;
using System.Windows.Forms;

namespace CowCalculator
{
    public partial class Form1 : Form
    {
        private Farmer farmer;
        public Form1() // Esse é o construtor da classe Form1
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void numberOfCowsController_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numberOfCowsController.Value;
        }
    }
}

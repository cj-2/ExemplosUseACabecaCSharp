using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyCalc
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyOption.Checked, fancyDecoration.Checked);
            DisplayDinnerPartyCoast();
        }

        void DisplayDinnerPartyCoast()
        {
            dinnerParty.SetOptions((int)numericUpDown1.Value, healthyOption.Checked, fancyDecoration.Checked);

            decimal Cost = dinnerParty.CalculateCost();
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCoast();
        }

        private void fancyDecoration_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCoast();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyOption.Checked);
            DisplayDinnerPartyCoast();
        }
    }
}

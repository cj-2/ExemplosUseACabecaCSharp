using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numberParty.Value, healthyOption.Checked, fancyDecoration.Checked);
            DisplayDinnerPartyCoast();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCoast();
        }

        void DisplayDinnerPartyCoast()
        {
            dinnerParty.SetOptions((int)numberParty.Value, healthyOption.Checked, fancyDecoration.Checked);

            decimal Cost = dinnerParty.CalculateCost();
            dinnerCost.Text = Cost.ToString("c");
        }

        private void numberParty_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCoast();
        }

        private void fancyDecoration_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCoast();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCoast();
        }

        void DisplayBirthdayPartyCoast()
        {
            birthdayParty.SetOptions((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            cakeWriting.Text = birthdayParty.CakeWriting;
            decimal Cost = birthdayParty.CalculateCost();
            birthdayCost.Text = Cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            DisplayBirthdayPartyCoast();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            DisplayBirthdayPartyCoast();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            DisplayBirthdayPartyCoast();
        }
    }
}

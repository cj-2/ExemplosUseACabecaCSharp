using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2GuysAndMuchMoney
{
    public partial class Form1 : Form
    {
        Guy Joe;
        Guy Bob;
        int Bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = Joe.Name + " has R$ " + Joe.Cash;
            bobsCashLabel.Text = Bob.Name + " has R$ " + Bob.Cash;
            bankCashLabel.Text = "The Bank has R$ " + Bank;
        }

        public Form1()
        {
            InitializeComponent();

            Joe = new Guy();
            Joe.Name = "Joe";
            Joe.Cash = 50;

            Bob = new Guy();
            Bob.Name = "Bob";
            Bob.Cash = 100;

            UpdateForm();
        }

        private void GiveToJoeButton_Click(object sender, EventArgs e)
        {
            if (Bank >= 10)
            {
                Bank -= Joe.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The Bank is out of money.");
            }
        }

        private void ReciveFromBobButton_Click(object sender, EventArgs e)
        {
            Bank += Bob.GiveCash(5);
            UpdateForm();
        }
    }
}

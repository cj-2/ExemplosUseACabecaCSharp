using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayMeToDriveMyCar
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateMileages()
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage > endingMileage)
            {
                MessageBox.Show("A quilometrage inicial deve ser menor que a final!", "Impossível Calcular");
                return;
            }

            milesTraveled = endingMileage - startingMileage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateMileages();
            amountOwed = milesTraveled * reimburseRate;
            label4.Text = "$" + amountOwed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateMileages();
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}

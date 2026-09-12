using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int number = 15;
            //number = number + 10;
            //number = 36 * 15;
            //number = 12 - (42 / 7);
            //number += 10;
            //number *= 3;
            //number = 71 / 3;

            //MessageBox.Show("" + number);

            //int count = 0;
            //count++;
            //count--;

            //string result = "hello";
            //result += " again " + result;
            //MessageBox.Show(result);
            //result = "the value is: " + count;
            //result = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // just
            string name = "Carlim";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;

            MessageBox.Show("My name is " + name + "\nx is " + x + "\nd is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x must be 10");
            }
            else
            {
                MessageBox.Show("x isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr";

            if ((someValue == 3) && (name == "Joe"))
            {
                MessageBox.Show("x is 3 and the name is Joe");
            }
            MessageBox.Show("this line runs no metter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                count--;
            }

            MessageBox.Show("The answer is " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = 2;
            for (int q = 2; q < 32; q *= 2)
            {
                while (p < q)
                {
                    p = q * 2;
                }
                q = p - q;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    result += "a";
                }

                x--;
                result += "-";

                if (x == 2)
                {
                    result += "b c";
                }

                if (x == 1)
                {
                    result += "d";
                    x--;
                }

            }

            MessageBox.Show(result);
        }
    }
}

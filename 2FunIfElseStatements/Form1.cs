using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FunIfElseStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                if (this.label1.BackColor == Color.Red)
                {
                    this.label1.BackColor = Color.Blue;
                    this.label1.ForeColor = Color.White;
                }
                else
                {
                    this.label1.BackColor = Color.Red;
                    this.label1.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show("The box is not checked!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

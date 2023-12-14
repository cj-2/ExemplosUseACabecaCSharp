using System;
using System.Windows.Forms;

namespace TheTallGuyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Carlinhos" };
            // tallGuy.TalkAboutYourself();
            tallGuy.Hoink();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Pack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            MessageBox.Show(card.Name);
        }
    }
}

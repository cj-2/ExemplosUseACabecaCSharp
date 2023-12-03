using System.Windows.Forms;

namespace _2Elephants
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " tall.", Name + " says...");
        }
    }
}

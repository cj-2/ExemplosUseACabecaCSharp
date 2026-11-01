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

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message, "From: " + whoSaidIt.Name + " on " + Name);
        }

        public void SpeakTo(Elephant whoTalkTo, string message)
        {
            whoTalkTo.TellMe(message, this);
        }
    }
}

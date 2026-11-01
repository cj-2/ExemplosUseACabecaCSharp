using System.Windows.Forms;

namespace TheTallGuyTest
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave { get { return "Big Shoes"; } }

        public void Hoink()
        {
            MessageBox.Show("Honk honk!", "The clown says...");
        }

        public void TalkAboutYourself()
        {
            MessageBox.Show("My name is " + " and I'm " + Height + " inches tall.");
        }
    }
}

using System.Windows.Forms;

namespace TheTallGuyTest
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;

        public string ScaryThingsIHave { get { return "I have " + numberOfScaryThings + " spiders."; } }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha! Look my " + funnyThingIHave, "The clown says...");
        }
    }
}

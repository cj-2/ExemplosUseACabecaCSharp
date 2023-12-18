using System.Windows.Forms;

namespace TheTallGuyTest
{
    internal class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave { get { return "Honk honk! I have a " + funnyThingIHave; } }

        public void Hoink()
        {
            MessageBox.Show(FunnyThingIHave, "The clown says...");
        }
    }
}

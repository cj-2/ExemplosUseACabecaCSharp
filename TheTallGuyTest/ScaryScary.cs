using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string ScaryThingsIHave { get { return "I have " + numberOfScaryThings + " spiders"; } }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha", "The clown says...");
        }
    }
}

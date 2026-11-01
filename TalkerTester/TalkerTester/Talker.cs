using System.Windows.Forms;

namespace TalkerTester
{
    internal class Talker
    {
        public static int BlaBlaBla(string thingToSay, int numberOfTimes)
        {
            string finalString = "";

            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }

            MessageBox.Show(finalString);

            return finalString.Length;
        }
    }
}

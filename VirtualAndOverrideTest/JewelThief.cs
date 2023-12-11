namespace VirtualAndOverrideTest
{
    internal class JewelThief : Locksmith
    {
        private Jewels? stolenJewels = null;

        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}

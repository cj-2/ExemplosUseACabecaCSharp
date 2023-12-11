namespace VirtualAndOverrideTest
{
    internal class Owner
    {
        private Jewels? returnedContents;

        public void ReceiveContents(Jewels? safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + returnedContents.Sparkle());
        }
    }
}

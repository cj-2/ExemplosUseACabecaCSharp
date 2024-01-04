namespace DuckConsole
{
    internal class Duck
    {
        public int Size;

        public KindOfDuck Kind;

        public override string ToString()
        {
            return "Type: " + Kind.ToString() + ", Size: " + Size;
        }
    }
}

namespace DuckConsole
{
    internal class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public override string ToString()
        {
            return "Um pato do tipo " + Kind + " com " + Size + " inch";
        }

        public int CompareTo(Duck otherDuck)
        {
            if (this.Size > otherDuck.Size) return 1;
            else if (this.Size < otherDuck.Size) return -1;
            return 0;
        }
    }
}

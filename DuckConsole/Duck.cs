namespace DuckConsole
{
    internal class Duck: IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public override string ToString()
        {
            return "Type: " + Kind.ToString() + ", Size: " + Size;
        }

        public int CompareTo(Duck otherDuck)
        {
            if(this.Size > otherDuck.Size)
            {
                return 1;
            } else if (this.Size < otherDuck.Size)
            {
                return -1;
            } else
            {
                return 0;
            }
        }
    }
}

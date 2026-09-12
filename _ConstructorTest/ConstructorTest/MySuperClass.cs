namespace ConstructorTest
{
    internal class MySuperClass
    {
        public MySuperClass(string superClassNeeds) {
            Console.WriteLine("This is the superclass: " + superClassNeeds);
        }
    }

    internal class MySubClass : MySuperClass {
        public MySubClass(string superClassNeeds, int anotherValue) : base(superClassNeeds)
        {
            Console.WriteLine("This is the subclass: " + superClassNeeds + " and " + anotherValue);
        }
    }
}

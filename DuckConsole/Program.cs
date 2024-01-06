namespace DuckConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> Ducks = [
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 }, // sintaxe completa
                new() { Kind = KindOfDuck.Muscovy, Size = 18 }, // sintaxe reduzida
                new() { Kind = KindOfDuck.Decoy, Size = 14 },
                new() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new() { Kind = KindOfDuck.Mallard, Size = 14 },
                new() { Kind = KindOfDuck.Decoy, Size = 13 },
            ];

            Console.WriteLine("Sem ordenação:");
            PrintDucks(Ducks);

            Console.WriteLine("Ordenado pelo tamanho utilizando o IComparable<Duck>:");
            // Ordenando por tamanho, utilizano o IComparable<Duck> do objeto
            Ducks.Sort();
            PrintDucks(Ducks);

            Console.WriteLine("Ordenando por tamanho utilizando IComparer<Duck> (classe ordenadora):");
            // Ordenando por tamanho.
            DuckComparerBySize sizeCompare = new DuckComparerBySize();
            Ducks.Sort(sizeCompare); // passando a classe ordenadora
            PrintDucks(Ducks);

            Console.WriteLine("Ordenando por tipo utilizando IComparer<Duck> (classe ordenadora):");
            // Ordenando pelo tipo.
            DuckComparerByKind kindCompare = new();
            Ducks.Sort(kindCompare);
            PrintDucks(Ducks);

            Console.WriteLine("Ordenando por tipo e tamanho utilizando IComparer<Duck> (classe ordenadora):");
            // Ordenando primeiro pelo tipo e depois pelo tamanho.
            DuckComparer comparer = new();
            comparer.SortBy = SortCriteria.KindThenSize;
            Ducks.Sort(comparer);
            PrintDucks(Ducks);

            Console.WriteLine("Ordenando por tamanho e tipo utilizando IComparer<Duck> (classe ordenadora):");
            // Ordenando primeiro por tamanho e depois por tipo.
            comparer.SortBy = SortCriteria.SizeThenKind;
            Ducks.Sort(comparer);
            PrintDucks(Ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.ToString());

            Console.WriteLine("End of Ducks!");
        }
    }
}
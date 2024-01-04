using DuckConsole;

List<Duck> Ducks = new List<Duck>() {
    new Duck(){ Kind = KindOfDuck.Mallard, Size = 17 }, // sintaxe completa
    new (){ Kind = KindOfDuck.Muscovy, Size = 18 }, // sintaxe reduzida
    new (){ Kind = KindOfDuck.Decoy, Size = 14 },
    new (){ Kind = KindOfDuck.Muscovy, Size = 11 },
    new (){ Kind = KindOfDuck.Mallard, Size = 14 },
    new (){ Kind = KindOfDuck.Decoy, Size = 13 },
};

foreach (Duck duck in Ducks)
{
    Console.WriteLine(duck.ToString());
}

Console.ReadKey();
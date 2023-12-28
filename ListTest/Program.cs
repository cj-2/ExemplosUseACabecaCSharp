List<string> shoes =
[
    "Sapatinho 1",
    "Sapatinho 2",
    "Sapatinho 3",
    "Sapatinho 4",
    "Sapatinho 5",
    "Sapatinho 6",
];

int numberOfShoes = shoes.Count;

shoes.RemoveAt(4); // remove baseado no índice

foreach (string name in shoes)
{
    Console.WriteLine(name);
}

shoes.Add("Novo Sapatinho");

string lastShoe = shoes[shoes.Count - 1];

shoes.Clear(); // limpa as referências da lista

Console.WriteLine(lastShoe); // continua existindo pois salvamos sua referência

shoes.Add(lastShoe);

if (shoes.Contains(lastShoe))
{
    Console.WriteLine("Está aqui dentro!");
}
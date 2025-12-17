var birds = new List<Bird>()
{
    new() { Name = "Joaquim" },
    new Penguin() { Name = "Geraldo" },
    new Duck () { Name = "Francisco" }
};

foreach (var bird in birds)
{
    Console.WriteLine(bird);
}

var birdsByName = new Dictionary<string, Bird>();
birdsByName.Add("joaquim", new Bird(name: "Joaquim"));
birdsByName.Add("geraldo", new Bird(name: "Geraldo"));
birdsByName.Add("francisco", new Bird(name: "Francisco"));

if (birdsByName.ContainsKey("joaquim"))
{
    Console.WriteLine("achei o joaquim");
}

birdsByName.Remove("joaquim");

foreach (var k in birdsByName.Keys)
{
    Console.WriteLine(k);
}
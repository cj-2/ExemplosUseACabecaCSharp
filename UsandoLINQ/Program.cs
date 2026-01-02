using UsandoLINQ;

var intList = new[] { 1, 2, 25, 5, 3, 10, 12, 26, 18, 4 };

var result =
    from i in intList
    where i > 3
    orderby i
    select i + "s";

foreach (var r in result)
{
    Console.Write(r + " ");
}

Console.WriteLine();

var valores = new Dictionary<int, decimal>
{
    { 6, 3600m },
    { 19, 8600m },
    { 36, 200m },
    { 57, 600m },
};

var revistinhas = new List<Revistinha>()
{
    new() { Nome = "Supremo H", Edicao = 57 },
    new() { Nome = "Jota o G", Edicao = 19 },
    new() { Nome = "Não olhe...", Edicao = 36 },
    new() { Nome = "Melhor olhar!", Edicao = 6 },
    // new() { Nome = "Fora de tudo", Edicao = 12 },
};

var consulta =
    from r in revistinhas
    where valores[r.Edicao] > 300
    orderby valores[r.Edicao] descending
    select r;

var resultadoConsulta = consulta.ToList();

foreach (var r in resultadoConsulta)
{
    Console.WriteLine($"{r.Nome}: {valores[r.Edicao]:c}");
}

// Console.WriteLine(consulta.Count()); // Se eu chamar de novo vai loopar novamente.
Console.WriteLine(resultadoConsulta.Count);
namespace Testes;

sealed class ClasseBobinha {};

static class ExensaoClasseBobinha
{
    public static void ImprimirAlgo(this ClasseBobinha _, string m)
    {
        Console.WriteLine(m);
    }
}
class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Não sei voar!");
    }
    
    public override string ToString()
    {
        return "Um penguin chamado " + Name;
    }
}
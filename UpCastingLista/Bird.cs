class Bird
{
    public Bird()
    {
    }

    public Bird(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public virtual void Fly()
    {
        Console.WriteLine("flap, flap");
    }

    public override string ToString()
    {
        return "Um pássaro chamado " + Name;
    }
}
namespace Eventos;

public class Bola
{
    public event EventHandler<BolaEventArgs>? BolaEmJogo;

    public void EmJogo()
    {
        var random = new Random();
        var eventArgs = new BolaEventArgs
        {
            Velocidade = random.Next(0, 120),
            Posicao = random.Next(10)
        };

        Console.WriteLine($"(Bola) Volocidade: {eventArgs.Velocidade}, Posição: {eventArgs.Posicao}");
        BolaEmJogo?.Invoke(this, eventArgs);
    }
}
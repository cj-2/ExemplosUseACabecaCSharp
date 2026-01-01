namespace Eventos;

public class Jogador(string nome, int posicao = 0)
{
    private string Nome { get; set; } = nome;
    private int Posicao { get; set; } = posicao;

    // Manipulador do evento.
    public void bola_BolaEmJogo(object sender, BolaEventArgs e)
    {
        var random = new Random();
        Posicao = random.Next(10);

        var jogadorInfo = $"Jogador: {Nome}, Posição: {Posicao} -";
        
        if (e.Posicao > Posicao)
        {
            if (e.Velocidade > 80)
            {
                Console.WriteLine($"{jogadorInfo} A bola me passou e está muito rápida!");
            }
            else
            {
                Console.WriteLine($"{jogadorInfo} Putz, a bola me passou, mas da pra buscar...");
            }
        }
        else
        {
            if (e.Velocidade > 80)
            {
                Console.WriteLine($"{jogadorInfo} A bola está vindo na minha direção muito rápida!");
            }
            else
            {
                Console.WriteLine($"{jogadorInfo} A bola está vindo mas dá pra pegar.");
            }
        }
    }
}
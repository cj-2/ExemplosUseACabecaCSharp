using Eventos;

var bola = new Bola();
var juiz = new Juiz();
var jogador1 = new Jogador("Roberto");
var jogador2 = new Jogador("Marciano");

// Inscrevendo interssandos nos eventos:
bola.BolaEmJogo += juiz.bola_BolaEmJogo;
bola.BolaEmJogo += jogador1.bola_BolaEmJogo;
bola.BolaEmJogo += jogador2.bola_BolaEmJogo;

while (true)
{
    Console.WriteLine("Aperte qualquer tecla para a bola rolar!");
    if(Console.ReadLine() == "fim") break;
    
    bola.EmJogo();
    Console.WriteLine();
}

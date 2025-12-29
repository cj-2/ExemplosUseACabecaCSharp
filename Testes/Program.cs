// Exemplo de escita de números em hexa
const int j = 0x20; // O 0x que informa que vamos digitar um número em hexa
Console.WriteLine("Valor em decimal, pois é convertido em decimal: " + j);

var h = String.Format("Já esse valor é em hexa: {0:x2}", j); // o x2 matem em hexa
Console.WriteLine(h); // Aqui manteve no hexa
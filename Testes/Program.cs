using System.Text;
using Testes;

// Exemplos de impressão de hexadecimal
const int j = 0x20; // O 0x que informa que vamos digitar um número em hexadecimal
Console.WriteLine("Valor em decimal, pois é convertido em decimal: " + j);

var h = String.Format("Já esse valor é em hexa: {0:x2}", j); // o x2 mantem em hexadecimal
Console.WriteLine(h);

// Exemplo de leitura e escria de binários
using (var file = File.Open("inputFile.bin", FileMode.OpenOrCreate))
{
    using var inputWriter = new BinaryWriter(file, Encoding.UTF8);
    inputWriter.Write("Essa string será convertida em binário.");
    inputWriter.Write(726381723);
    inputWriter.Write("Outra string...");
}

using (var readFile = File.Open("inputFile.bin", FileMode.Open))
{
    using var fileText = new BinaryReader(readFile);
    Console.WriteLine(fileText.ReadString());
    Console.WriteLine(fileText.ReadInt32());
    Console.WriteLine(fileText.ReadString());
}

var conversor = new ConvertIntToString((valor => $"É esse valor: {valor}"));
Console.WriteLine(conversor(20));

int? numero;
numero = 2;
Console.WriteLine(numero);

var bobinha = new ClasseBobinha();
bobinha.ImprimirAlgo("Olha só, agora a classe faz alguma coisa.");
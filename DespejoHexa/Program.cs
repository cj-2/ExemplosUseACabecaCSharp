// Funciona apenas com arquivos de texto

if (!File.Exists("inputFile.txt"))
{
    using var inputWriter = new StreamWriter("inputFile.txt", false);
    inputWriter.Write("Esse é apenas um exemplo de texto que será exibido no console como hexadecimal.");
}

using var reader = new StreamReader("inputFile.txt");
using var writer = new StreamWriter("outputFile.txt", false);

var position = 0;

while (!reader.EndOfStream)
{
    var buffer = new char[16];
    var charactersRead = reader.ReadBlock(buffer, 0, 16);
    
    writer.Write("{0:x4}: ", position);
    position += charactersRead;

    for (var i = 0; i < 16; i++)
    {
        if (i < charactersRead)
        {
            writer.Write("{0:x2} ", (byte)buffer[i]);
        }
        else
        {
            writer.Write(" ");
        }

        if (i == 7)
        {
            writer.Write("-- ");
        }

        if (buffer[i] < 32 || buffer[i] > 250)
        {
            buffer[i] = '.';
        }
    }
    
    var bufferContents = new string(buffer);
    writer.WriteLine(string.Concat(" ", bufferContents.AsSpan(0, charactersRead)));
}

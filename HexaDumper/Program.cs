using System.Text;

if (args.Length == 0)
{
    Console.Error.WriteLine("Informe um arquivo para ser lido.");
    Environment.Exit(1);
}

if (!File.Exists(args[0]))
{
    Console.Error.WriteLine($"Arquivo não encontrado: {args[0]}");
    Environment.Exit(2);
}

using var input = File.OpenRead(args[0]);

var position = 0;

while (position < input.Length)
{
    var buffer = new byte[16];
    var charactersRead = input.Read(buffer, 0, buffer.Length);
    if (charactersRead <= 0) continue;

    Console.Write("{0:x4}: ", position);
    position += charactersRead;

    for (var i = 0; i < 16; i++)
    {
        if (i < charactersRead)
        {
            Console.Write("{0:x2} ", buffer[i]);
        }
        else
        {
            Console.Write("   ");
        }

        if (i == 7)
        {
            Console.Write("-- ");
        }

        if (buffer[i] < 32 || buffer[i] > 250)
        {
            buffer[i] = (byte)'.'; // é convertido por que o buffer é de bytes
        }
    }

    var bufferContents = Encoding.UTF8.GetString(buffer);
    // Console.WriteLine(bufferContents);
    Console.WriteLine(" " + bufferContents);
}
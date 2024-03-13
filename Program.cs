namespace BaseNamespace
{
    class Program
    {
        static void Main()
        {
            int typedValue;
            do
            {
                Write("0 - Sair");
                Write("1 - Hello World");
                Write("2 - Concatenação");
                Write("3 - Operações com números");
                Write("4 - Chars");
                Write("5 - Validação de placa de veículo");
                Write("6 - Data atual");
                Write("Digite a opção desejada: ", false);
                typedValue = ReadOption();

                switch (typedValue)
                {
                    case 0:
                    default:
                        break;
                    case 1:
                        HelloWorld.Run();
                        break;
                }
            } while (typedValue != 0);
        }

        static void Write(string message, bool writeLine = true)
        {
            if (writeLine)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
        }

        static int ReadOption()
        {
            return int.Parse(Console.ReadLine()!);
        }
    }
}
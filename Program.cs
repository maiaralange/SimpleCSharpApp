namespace BaseNamespace
{
    class Program
    {
        private static readonly int DEFAULT_VALUE = 0;

        static void Main()
        {
            int typedValue;
            do
            {
                Write("0 - Exit");
                Write("1 - Hello World");
                Write("2 - Concatenation");
                Write("3 - Math operations");
                Write("4 - Chars");
                Write("5 - Validate vehicle plate (2018 Brazil regulation)");
                Write("6 - Current date");
                Write("Please type your option: ", false);
                typedValue = ReadOption();

                switch (typedValue)
                {
                    case 0:
                    default:
                        break;
                    case 1:
                        HelloWorld.Run();
                        break;
                    case 2:
                        Concatenation.Run();
                        break;
                    case 3:
                        MathOperations.Run();
                        break;
                    case 4:
                        Chars.Run();
                        break;
                    case 5:
                        ValidateVehiclePlate.Run();
                        break;
                    case 6:
                        CurrentDate.Run();
                        break;
                }
            } while (typedValue != 0);

            Console.WriteLine("\nProgram ended. Please press 'Enter' to exit.");
            Console.ReadLine();
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
            var value = Console.ReadLine();
            if (!string.IsNullOrEmpty(value))
            {
                return int.Parse(value);
            }

            return DEFAULT_VALUE;
        }
    }
}
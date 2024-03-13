namespace BaseNamespace
{
    public static class MathOperations
    {
        private static readonly int DEFAULT_VALUE = 0;

        public static void Run()
        {
            Console.WriteLine();
            Console.Write("Write the first integer: ");
            int firstValue = ReadValue();
            Console.Write("Write the second integer: ");
            int secondValue = ReadValue();

            Console.WriteLine($"Parsed integers: {firstValue} e {secondValue}");

            Console.WriteLine($"Sum: {firstValue + secondValue}");
            Console.WriteLine($"Subtraction: {firstValue - secondValue}");
            Console.WriteLine($"Multiplication: {firstValue * secondValue}");

            if (secondValue != 0)
            {
                var division = Convert.ToDouble(firstValue) / secondValue;
                Console.WriteLine($"Division: {Math.Round(division, 2)}");
            }
            else
            {
                Console.WriteLine("Division by zero is not possible. Please use another number as denominator.");
            }

            Console.WriteLine($"Average: {(firstValue + secondValue) / 2}");
            Console.WriteLine();
        }

        private static int ReadValue()
        {
            var value = Console.ReadLine();
            if (!string.IsNullOrEmpty(value))
            {
                return int.Parse(value);
            }

            Console.WriteLine($"No integer was typed. Using default value {DEFAULT_VALUE}");
            return DEFAULT_VALUE;
        }
    }
}

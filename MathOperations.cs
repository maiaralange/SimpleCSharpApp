namespace BaseNamespace
{
    public static class MathOperations
    {
        private static readonly int DEFAULT_VALUE = 0;

        public static void Run()
        {
            Console.WriteLine();
            Console.Write("Digite o primeiro número inteiro: ");
            int firstValue = ReadValue();
            Console.Write("Digite o segundo número inteiro: ");
            int secondValue = ReadValue();

            Console.WriteLine($"Valores utilizados: {firstValue} e {secondValue}");

            Console.WriteLine($"Soma: {firstValue + secondValue}");
            Console.WriteLine($"Subtração: {firstValue - secondValue}");
            Console.WriteLine($"Multiplicação: {firstValue * secondValue}");

            if (secondValue != 0)
            {
                var division = Convert.ToDouble(firstValue) / secondValue;
                Console.WriteLine($"Divisão: {Math.Round(division, 2)}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por 0. Utilize outro número como denominador.");
            }

            Console.WriteLine($"Média: {(firstValue + secondValue) / 2}");
            Console.WriteLine();
        }

        private static int ReadValue()
        {
            var value = Console.ReadLine();
            if (!string.IsNullOrEmpty(value))
            {
                return int.Parse(value);
            }

            Console.WriteLine("Não foi digitado nenhum número. Usando valor padrão '0'.");
            return DEFAULT_VALUE;
        }
    }
}

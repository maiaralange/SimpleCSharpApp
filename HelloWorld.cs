namespace BaseNamespace
{
    public static class HelloWorld
    {
        public static void Run()
        {
            Console.Write("Digite seu nome: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Olá, {name}! Seja bem-vindo/a!");
            Console.WriteLine();
        }
    }
}

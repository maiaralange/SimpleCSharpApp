namespace BaseNamespace
{
    public static class HelloWorld
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.Write("Write your name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome!");
            Console.WriteLine();
        }
    }
}

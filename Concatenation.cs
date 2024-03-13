namespace BaseNamespace
{
    public static class Concatenation
    {
        public static void Run()
        {
            Console.WriteLine();

            Console.Write("Write your first name: ");
            var name = Console.ReadLine();

            Console.Write("Write your last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Full name: {name} {lastName}");

            Console.WriteLine();
        }
    }
}

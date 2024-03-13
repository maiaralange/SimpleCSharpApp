namespace BaseNamespace
{
    public static class Chars
    {
        public static void Run()
        {
            Console.WriteLine();

            Console.Write("Type the char/word/phrase to count the # of chars: ");
            string? value = Console.ReadLine();
            
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("No value was typed. Please try again.");
                Console.WriteLine();
                return;
            }

            var chars = value.ToCharArray();
            var charsWithoutSpaces = chars.Where(x => x != ' ').ToList();
            Console.WriteLine($"Number of chars: {charsWithoutSpaces.Count}");

            Console.WriteLine();
        }
    }
}

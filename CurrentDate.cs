namespace BaseNamespace
{
    public static class CurrentDate
    {
        public static void Run()
        {
            Console.WriteLine();

            var today = DateTime.Now;
            Console.WriteLine($"Full format: {today}");
            Console.WriteLine($"Format MM/DD/YYYY: {today.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"24 hour format: {today.ToString("HH:mm:ss")}");
            Console.WriteLine($"Format DD MMMM YYYY: {today.ToString("dd MMMM yyyy")}");

            Console.WriteLine();
        }
    }
}

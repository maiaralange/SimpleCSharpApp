using System.Text.RegularExpressions;

namespace BaseNamespace
{
    public static class ValidateVehiclePlate
    {
        private static readonly string PLATE_PATTERN = @"([A-Z]{3})(\d{4})";

        public static void Run()
        {
            Console.WriteLine();

            Console.Write("Write the vehicle plate, format ABC1234: ");
            var plate = Console.ReadLine();

            if (string.IsNullOrEmpty(plate))
            {
                Console.WriteLine("No value was typed. Please try again.");
                Console.WriteLine();
                return;
            }

            var chars = plate.ToCharArray();
            if (chars.Length != 7)
            {
                Console.WriteLine("The plate should be 7 chars long. Please try again.");
                Console.WriteLine();
                return;
            }

            if (Regex.IsMatch(plate, PLATE_PATTERN, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Plate is valid according to 2018 Brazil regulations.");
            }
            else
            {
                Console.WriteLine("Plate is invalid. Please use format ABC1234.");
            }

            Console.WriteLine();
        }
    }
}

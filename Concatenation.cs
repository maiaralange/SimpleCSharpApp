namespace BaseNamespace
{
    public class Concatenation
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.Write("Digite seu primeiro nome: ");
            var name = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Nome completo: {name} {lastName}");
            Console.WriteLine();
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku:");
        double y = double.Parse(Console.ReadLine());
        double tulos = x - y;
        Console.WriteLine(tulos);
    }
}
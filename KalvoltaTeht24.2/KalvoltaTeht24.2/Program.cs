internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku:");
        double luku1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku:");
        double luku2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku:");
        double luku3 = double.Parse(Console.ReadLine());
        double isoin = Math.Max(Math.Max(luku1, luku2), luku3);
        Console.WriteLine("Isoin numero on: " + isoin);
    }
}
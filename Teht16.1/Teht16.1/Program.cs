internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku: ");
        double x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Anna toinen luku: ");
        double y = Int32.Parse(Console.ReadLine());
        double vastaus = x + y;
        Console.WriteLine(vastaus);
    }
}
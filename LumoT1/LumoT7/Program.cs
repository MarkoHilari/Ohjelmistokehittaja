internal class Program
{
    private static void Main(string[] args)
    {
        double fah = 98;
        double cel = (fah - 32) / 1.8;
        Console.WriteLine(Math.Round(cel,2));
    }
}
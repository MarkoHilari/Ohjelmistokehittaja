internal class Program
{
    private static void Main(string[] args)
    {
        double cel = 36.6;
        double fah = cel * 1.8 + 32;
        Console.WriteLine(Math.Round(fah,1));
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Muutetaan Celsius fahrenheitiksi");
        Console.WriteLine("Anna celsius aste:");
        double cel = double.Parse(Console.ReadLine());
        double fah = (cel * 1.8) + 32;
        Console.WriteLine("Vastaus on " + fah + " fahrenheitia!");
    }
}
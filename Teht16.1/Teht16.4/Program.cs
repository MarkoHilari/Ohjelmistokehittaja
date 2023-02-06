internal class Program
{
    private static void Main(string[] args)
    {
    stars:
        double x, y;
        try
        {
            Console.WriteLine("Anna luku: ");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku: ");
            y = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Anna oikea arvo");
            goto stars;
        }
        double vastaus = x / y;
        Console.WriteLine("Vastaus on: " + x + " / " + y + " = " + vastaus);
    }
}
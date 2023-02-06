internal class Program
{
    private static void Main(string[] args)
    {
    stars:
        double x, y, vastaus;
        try
        {
            Console.WriteLine("Syötä luvut josta haluat - laskun");
            Console.Write("Anna luku: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            y = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Anna oikea arvo");
            goto stars;
        }
        double vx = x;
        //x = x + y;
        x -= y;
        Console.WriteLine("Vastaus on: " + vx + " - " + y + " = " + x);
        Console.WriteLine("Jatketaanko? k/e?");
        string jatko = Console.ReadLine();
        while (jatko == "k" || jatko == "K")
        {
            goto stars;
        }
    }
}
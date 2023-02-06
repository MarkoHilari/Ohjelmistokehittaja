internal class Program
{
    private static void Main(string[] args)
    {
    stars:
        double x, y;
        try
        {
            Console.WriteLine("Syötä luvut josta haluat jakojäännöksen");
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
        double vastaus = x % y;
        Console.WriteLine("Vastaus on: " + x + " % " + y + " = " + vastaus);
        Console.WriteLine("Jatketaanko? k/e?");
        string jatko = Console.ReadLine();
        while(jatko == "k" || jatko == "K")
        {
            goto stars;
        }

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string kayttjanValinta;
        int tkValinta;
        alku:
        try
        {
            Console.WriteLine(" Kivi, paperi, sakset:");
            Console.WriteLine("1. Kivi");
            Console.WriteLine("2. Paperi");
            Console.WriteLine("3. Sakset");
            Console.WriteLine("Valitse 1, 2 tai 3: ");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ole hyvä ja valitse 1-3");
        }

        kayttjanValinta = Console.ReadLine();
        tkValinta = new Random().Next(1, 4);

        Console.WriteLine("Sinä valitsit: " + kayttjanValinta);
        Console.WriteLine("Tietokone valitsi: " + tkValinta);

        if (kayttjanValinta == "1" && tkValinta == 3 ||
            kayttjanValinta == "2" && tkValinta == 1 ||
            kayttjanValinta == "3" && tkValinta == 2)
        {
            Console.WriteLine("Sinä voitit!");
        }
        else if (kayttjanValinta == "1" && tkValinta == 2 ||
                 kayttjanValinta == "2" && tkValinta == 3 ||
                 kayttjanValinta == "3" && tkValinta == 1)
        {
            Console.WriteLine("Tietokone voitti!");
        }
        
        else
        {
            Console.WriteLine("Tasapeli!");
        }

        Console.ReadLine();
        Console.WriteLine("Aloita uusi peli? k/e?");
        string uusiPeli = Console.ReadLine();
        while(uusiPeli == "k" || uusiPeli == "K")
        {
            goto alku;
        }
    }
}
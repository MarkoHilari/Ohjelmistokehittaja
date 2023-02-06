internal class Program
{
    private static void Main(string[] args)
    {
        int luku1, luku2;
    alku:
        Console.Clear();
        Console.WriteLine("Ohjelma tarkastaa onku luku negatiivinen vai positiivinen");
        try
        {
            Console.WriteLine("Anna ensimmäinen luku:");
            luku1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku:");
            luku2 = Int32.Parse(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Et antanut kokonaislukua! Ole hyvä ja yritä uudelleen");
            goto alku;
        } 
        if(luku1 >=0 && luku2 >= 0)
        {
            Console.WriteLine("Luvut ovat positiivisia");
        }
        else if(luku1 <= 0 && luku2 < 0)
        {
            Console.WriteLine("Luvut ovat negatiivisia");
        }
        else 
        {
            Console.WriteLine("Toinen luvuista on positiivinen ja toinen negatiivinen");
        }
        Console.WriteLine("Aloita alusta (k/e)");
        string vastaus = Console.ReadLine();
        if (vastaus == "k" || vastaus == "K")
        {
            goto alku;
        }
    }
}
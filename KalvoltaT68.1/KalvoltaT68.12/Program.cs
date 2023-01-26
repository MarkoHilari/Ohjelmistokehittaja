internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
    alku:
        try
        {
            Console.Clear();
            Console.WriteLine("Ole hyvä ja anna 10:ntä suurempi luku: ");
            luku = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
            goto alku;
        }
        for (int i = 0; i < luku; i++)
        {
            for (int j = 0; j < luku; j++)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();
            for (int k = 0; k < luku; k++)
            {
                Console.Write(luku);
            }
            Console.WriteLine();
        }

    }
}
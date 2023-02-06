internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        alku:
        Console.WriteLine("Tulostaa pisimmän sanan lauseesta");
        string lause;
        Console.Write("Anna lause: ");
        lause = Console.ReadLine();
        string[] taulu = lause.Split(' ');
        string pisin = taulu[0];
        for (int i = 1;i < taulu.Length; i++)
        {
            if (taulu[i].Length > pisin.Length)
            {
                pisin = taulu[i];
            }
        }
        Console.WriteLine("Syötetty lause on {0}, pisin sana on {1}", lause, pisin);
        Console.WriteLine("Aloita alusta (k/e)");
        string arvo = Console.ReadLine();
        if (arvo == "k" || arvo == "K")
        {
            goto alku;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
     

        string sana, uusisana;
        int pituus;
        Console.Clear();
        Console.Write("Anna sana jonka ek ja vika kirjain vaihdetaan keskenään");
        sana = Console.ReadLine();
        pituus = sana.Length;
        char[] taulu = new char[pituus];
        for (int i = 0; i < pituus; i++)
            taulu[i] = sana[i];
        taulu[0] = sana[pituus - 1];
        taulu[pituus - 1] = sana[0];
        uusisana = String.Join("", taulu);
        Console.WriteLine("Annoit sanan {0} ja muutettu sana on {1}", sana, uusisana);
        
    }
}
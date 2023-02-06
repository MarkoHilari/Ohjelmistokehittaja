internal class Program
{
    private static void Main(string[] args)
    {
        int kluku;
        double dluku;
        string mjono, syote;
    alku:
        Console.WriteLine("Minkä tyyppiesen tiedon haluat syöttää (double, int, string) (d/i/s):");
        syote = Console.ReadLine();
        if (syote == "s" || syote == "i" || syote == "d" || syote == "S" || syote == "I" || syote == "D")
        {
            switch (syote)
            {
                case "s":
                case "S":
                    Console.WriteLine("Syotä merkkijono: ");
                    mjono = Console.ReadLine();
                    mjono += "*";
                    Console.WriteLine("Uusi merkkijono on: " + mjono);
                    break;
                case "d":
                case "D":
                dalku:
                    Console.WriteLine("Syötä doubleluku: ");
                    try
                    {
                        dluku = double.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + dluku + " ja tulos on " + (dluku + 1));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Ole hyvä ja syötä doubleluku");
                        goto dalku;
                    }
                    break;
                case "i":
                case "I":
                ialku:
                    Console.WriteLine("Syötä kokonaisluku");
                    try
                    {
                        kluku = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + kluku + " ja tulos on " + (kluku + 1));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Ole hyvä ja anna kokonaisluku");
                        goto ialku;
                    }
                    break;
                default:
                    Console.WriteLine("Jossakin on virhe!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Annoit väärän syötteen. Anna vain kirjain: d/i/s");
            goto alku;
        }
    }
    
}
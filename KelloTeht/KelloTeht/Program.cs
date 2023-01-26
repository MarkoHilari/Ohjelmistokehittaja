internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna kortin numero: ");
        int arvo = Int32.Parse(Console.ReadLine());
        string tulosta = Korttipakka(arvo);
        Console.WriteLine(tulosta);
        /*int tunnit, minuutti, sekuntti;
        for (tunnit = 0; tunnit < 24; tunnit++)
        {
            for (minuutti = 0; minuutti < 60; minuutti++)
            {
                for (sekuntti = 0; sekuntti < 60; sekuntti++)
                {
                    Console.WriteLine("{0}:{1}:{2}", tunnit, minuutti, sekuntti);
                }
            }
        }*/

    }
    static string Korttipakka(int luku)
    {
        switch (luku)
        {
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return luku.ToString();
                break;
            case 11:
                return ("J");
                break;
            case 12:
                return ("Q");
                break;
            case 13:
                return ("K");
                break;
            case 1:
                return ("A");
            default:
                return ("Annoit väärän luvun, ole hyvä tarkista antamasi arvo");
        }
    }
        
}
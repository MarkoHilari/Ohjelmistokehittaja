internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        Console.WriteLine("Ohjelma muuttaa numerot sanoiksi!!!!!");
        paluu:
        try
        {
            Console.Write("Anna luku väliltä 0-999: ");
            luku = Int32.Parse(Console.ReadLine());
        }
        catch ( Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Anatamasi luku on virheellinen, anna kokonaisluku väliltä 1-999");
            goto paluu;
        }
        if (luku < 0 || luku > 999) 
        {
            Console.WriteLine("Numero ei ole aluella 1-999");
            goto paluu;
        }




        Console.WriteLine("Aloitetaanko alusta (k/e)?");
        string vastaus = Console.ReadLine();
        if (vastaus == "k" || vastaus == "K")
        {
            goto paluu;
        }
    }
}
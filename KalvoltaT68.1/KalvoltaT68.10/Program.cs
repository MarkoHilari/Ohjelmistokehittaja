internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        Console.WriteLine("Syötä numero väliltä 1-10:");
        luku = int.Parse(Console.ReadLine());

        if (luku >= 1 && luku <= 10)
        {
            Console.WriteLine("Kertotaulu " + luku + ":");
            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(luku + " x " + i + " = " + (luku * i));
            }
        }
        else
        {
            Console.WriteLine("Numero ei aluella, tarkista syötetty arvo.");
        }
    }
}
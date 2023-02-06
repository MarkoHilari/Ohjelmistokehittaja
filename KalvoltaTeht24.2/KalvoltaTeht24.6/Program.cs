internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Syötä luku 1-9 laskeaksesi bonukset");
        int bonus = Int32.Parse(Console.ReadLine());
        if (bonus > 0 && bonus <= 3) 
        {
            Console.WriteLine(bonus * 10);
        }
        else if (bonus > 3 && bonus <= 6)
        {
            Console.WriteLine(bonus * 100);
        }
        else if (bonus > 6 && bonus <= 9)
        {
            Console.WriteLine(bonus * 1000);
        }
        else 
        {
            Console.WriteLine("Syötit väärät luvut");
        }
    }
}
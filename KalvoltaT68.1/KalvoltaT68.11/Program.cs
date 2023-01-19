internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna ikäsi: ");
        int ika = int.Parse(Console.ReadLine());
        if (ika <= 18)
        {
            Console.WriteLine(ika + " Olet vielä lapsi");
        }
        else
        {
            Console.WriteLine(ika + " Näytät nuoremmalta");
        }
    }
}
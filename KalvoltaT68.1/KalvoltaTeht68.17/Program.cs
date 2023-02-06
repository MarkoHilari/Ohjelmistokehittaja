internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ohjelma tulostaa kolmella jaolliset luvut annetusta arvosta");
        Console.WriteLine("Anna luku: ");
        int luku = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= luku; i ++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }

        }
        Console.WriteLine();
    }
}
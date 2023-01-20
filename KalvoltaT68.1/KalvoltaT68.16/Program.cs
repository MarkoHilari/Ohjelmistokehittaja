internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ohjelma tulostaa parittomat luvut annetusta arvosta");
        Console.WriteLine("Anna luku: ");
        int luku = int.Parse(Console.ReadLine());
        if (luku % 2 == 0)
            {
                luku--;
            }
        for (int i = 1; i <= luku; i+=2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
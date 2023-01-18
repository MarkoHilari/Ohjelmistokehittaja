internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku:");
        double y = double.Parse(Console.ReadLine());
        if(x > y)
            {
            Console.WriteLine("Lukujen järjestys {0}, {1}", x, y);
        }
        else
        {
            Console.WriteLine("Lukujen järjestys {0}, {1}", y, x);
        }
        
    }
}
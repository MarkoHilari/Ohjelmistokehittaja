internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna viisi lukua");
        Console.WriteLine("Anna luku");
        int luku1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku");
        int luku2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku");
        int luku3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku");
        int luku4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku");
        int luku5 = int.Parse(Console.ReadLine());
        int [] numerot = {luku1, luku2,luku3,luku4,luku5};
        int isoin = numerot[0];
        for (int i = 0; i < numerot.Length; i++)
        {
            if (numerot[i] > isoin)
                isoin = numerot[i];
        }
        Console.WriteLine("Isoin numero on " + isoin);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna numero: ");
        int l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna toinen numero");
        int l2 = int.Parse(Console.ReadLine());
        int tulos = (l1 + l2);
        Console.WriteLine(tulos);
    }
}
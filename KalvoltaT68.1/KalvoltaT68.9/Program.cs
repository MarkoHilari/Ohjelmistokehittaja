internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna kaksi numeroa laskeaksesi jakojäännös!");
        Console.WriteLine("Anna ensimmäinen numero: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Anna toinen numero: ");
        int b = Int32.Parse(Console.ReadLine());
        int jakj = a % b;
        Console.WriteLine("Lukujen " + a + " ja " + b + " jakojäännös on " + jakj);
    }
}
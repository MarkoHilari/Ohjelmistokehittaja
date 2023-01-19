internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna kaksi lukua, jotka lasketaan 4:llä eri tavalla:");
        Console.WriteLine("Anna luku1: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku2: ");
        int b = Int32.Parse(Console.ReadLine());
        int summa, kerto, miinus;
        double jako;
        summa = a + b;
        kerto = a * b;
        miinus = a - b;
        jako = (double)a / b;
        Console.WriteLine("Lukujen " + a + " ja " + b + " Summa on " + summa);
        Console.WriteLine("Lukujen " + a + " ja " + b + " kerto on " + kerto);
        Console.WriteLine("Lukujen " + a + " ja " + b + " Erotus on " + miinus);
        Console.WriteLine("Lukujen " + a + " ja " + b + " Jako on " + jako);
    }
}
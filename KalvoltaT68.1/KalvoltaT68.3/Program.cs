internal class Program
{
    private static void Main()
    {
        int a = 8;
        int b = 5;
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
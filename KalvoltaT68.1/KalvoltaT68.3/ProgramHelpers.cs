internal static class ProgramHelpers
{
    private static void Main(double a, double b)
    {
        a = 8;
        b = 5;
        double summa, tulo, erotus;
        double jako;
        summa = a + b;
        tulo = a * b;
        erotus = a - b;
        jako = (double)a / b;
        Console.WriteLine("Summa on " + summa);
        Console.WriteLine("Tulo on " + tulo);
        Console.WriteLine("Erotus on " + erotus);
        Console.WriteLine("Jako on " + jako);
    }
}
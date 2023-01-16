internal class Program
{
    private static void Main(string[] args)
    {
        int tuuma = 50;
        float sentti = (float)(tuuma * 2.54);
        Console.WriteLine(tuuma + " tuumaa on " + Math.Round(sentti, 1) + " Senttiä");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int sentti = 50;
        float tuuma = (float)(sentti / 2.54);
        Console.WriteLine(sentti + " senttiä on " + Math.Round(tuuma,2) + " Tuumaa!");
    }
}
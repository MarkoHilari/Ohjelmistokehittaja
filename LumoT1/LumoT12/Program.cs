internal class Program
{
    private static void Main(string[] args)
    {
        int yard = 60;
        float meter = (float)(yard * 0.9144);
        Console.WriteLine(yard + " yardia on " + Math.Round(meter,2) + " metriä!");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int ml = 15;
        float km = (float)(ml * 1.609);
        Console.WriteLine(Math.Round(km,2) + " kilometriä");
    }
}
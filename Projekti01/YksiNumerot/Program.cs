using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1");
        Console.WriteLine("11");
        Console.WriteLine("101");
        Console.WriteLine("1001");
        //Tästä alkaa kellonajan näyttö
        /*ja
         * Kestää alle saakka*/
        var date1 = DateTime.Now;
        Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fi-FI")));

        Console.WriteLine(Math.Sqrt(50));


    }
}
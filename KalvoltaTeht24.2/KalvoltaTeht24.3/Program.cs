using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna luku väliltä 1-7");
        Console.WriteLine("Anna luku 1-7:");
        string numero = Console.ReadLine();
        switch(numero)
            {
            case "1":
                Console.WriteLine("Yksi");
            break;
            case "2":
                Console.WriteLine("Kaksi");
                break;
            case "3":
                Console.WriteLine("Kolme");
                break;
            case "4":
                Console.WriteLine("Neljä");
                break;
            case "5":
                Console.WriteLine("Viisi");
                break;
            case "6":
                Console.WriteLine("Kuusi");
                break;
            case "7":
                Console.WriteLine("Seitsemän");
                break;
                default: 
                Console.WriteLine("Luku ei ole alueella!!!!");
                break;
        }
    }
}
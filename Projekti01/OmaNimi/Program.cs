internal class Program
{
    private static void Main(string[] args)
    {
        //Kysytään käyttäjäjän etunimeä
        Console.Write("Anna Etunimesi: ");
        string fname = Console.ReadLine();
        //Kysytään käyttäjäjän sukunimeä
        Console.Write("Anna Sukunimesi: ");
        String sname = Console.ReadLine();
        //Tulostetaan konsoliin nimi sekä tervehdys
        Console.WriteLine("Heippa, " + fname + " " + sname);
        Console.WriteLine("Heippa {0} {1}", fname, sname);
        //Ohje käyttäjälle, että voi sulkea ikkunan
        Console.WriteLine("Voit nyt sulkea ikkunan!");
        Console.ReadLine();
    }
}
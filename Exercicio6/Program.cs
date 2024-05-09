namespace Exercicio6;

class Program
{
    static void Main()

    {
        DateTime dateComplete = DateTime.Now;

        Console.WriteLine(dateComplete);

        string dateShort = dateComplete.ToShortDateString();

        Console.WriteLine(dateShort);

        string only24h = dateComplete.ToString("HH:mm");
        Console.WriteLine(only24h);

        string dateLong = dateComplete.ToLongDateString();
        Console.WriteLine(dateLong);
    }
}
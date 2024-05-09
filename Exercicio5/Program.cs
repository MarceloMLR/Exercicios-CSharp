namespace Exercicio5;


class Program
{
    static void Main()
    {
        var placaIsValid = new VerificaPlaca();

        Console.WriteLine("Digite a placa do seu veiculo:");
        string placa = Console.ReadLine();

        bool placaValida = placaIsValid.PlacaIsValid(placa);

        Console.WriteLine(placaValida);



    }
}
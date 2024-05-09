namespace Exercicio3;

class Program
{
    static void Main()
    {
        double numero1 = 25.00;
        double numero2 = 0;

        var operacoesMatematicas = new OperacoesMatematicas(); 

        Console.WriteLine(operacoesMatematicas.Somar(numero1: numero1, numero2: numero2));
        Console.WriteLine(operacoesMatematicas.Subtrair(numero1: numero1, numero2: numero2));
        Console.WriteLine(operacoesMatematicas.Dividir(numero1: numero1, numero2: numero2));
        Console.WriteLine(operacoesMatematicas.Multiplicar(numero1: numero1, numero2: numero2));
        Console.WriteLine(operacoesMatematicas.Media(numero1: numero1, numero2: numero2));
    }
}
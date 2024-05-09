namespace Exercicio4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu texto aqui:");
        string texto = Console.ReadLine();
        int tamanhoTexto = texto.Count(t => !char.IsWhiteSpace(t));
        Console.WriteLine($"O texto possui {tamanhoTexto} sem contar com os espaços em branco");
    }
}
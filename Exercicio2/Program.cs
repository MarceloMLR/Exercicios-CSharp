namespace Exercicio2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome:");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = string.Join(" ", nome, sobrenome);

        Console.WriteLine($"Olá! {nomeCompleto}");
    }
}

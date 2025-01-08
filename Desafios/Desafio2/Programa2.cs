namespace Desafio2;

class Programa2
{
    static void Main()
    {
        string nome = " ";
        string sobrenome = " ";

        Console.WriteLine("Insira seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Insira seu sobrenome: ");
        sobrenome = Console.ReadLine();

        Console.WriteLine(String.Concat(nome + " " + sobrenome));
    }
}

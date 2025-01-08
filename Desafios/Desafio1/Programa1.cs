namespace Desafio1;
class Programa1
{
    static void Main()
    {
        string nome = " ";

        Console.WriteLine("Insira seu nome: ");

        nome = Console.ReadLine();

        Console.WriteLine(String.Concat("Olá, " + nome + "!" + " " + "Seja muito bem vindo!"));
    }
}

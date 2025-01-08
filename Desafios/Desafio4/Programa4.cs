namespace Desafio4;

class Programa4
{
    static void Main()
    {
        string texto;
        int contador = 0;

        Console.WriteLine("Digite uma ou mais palavras:");
        texto = Console.ReadLine();

        foreach (char c in texto)
        {
            if (c != ' ')
            {
                contador++;
            }
        }
        Console.WriteLine("O texto possui: " + contador + " caracteres");


    }
}

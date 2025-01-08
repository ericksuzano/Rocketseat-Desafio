namespace Desafio5;

class Programa5
{
    static void Main()
    {
        string placa = "";
        Console.WriteLine("Digite a placa do seu carro:");
        placa = Console.ReadLine();

        if (placa.Length == 7 )
        {
            bool primeirosSaoLetras = char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]);

            bool ultimosSaoNumeros = char.IsDigit(placa[3]) && char.IsDigit(placa[4]) && char.IsDigit(placa[5]) && char.IsDigit(placa[6]);

            if (primeirosSaoLetras && ultimosSaoNumeros)
            {
                Console.WriteLine("Seu carro existe");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
        else
        {
            Console.WriteLine("Esse carro não existe...");
        }
    }
}

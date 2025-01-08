using Desafio_3;

namespace Desafio3;

class Programa3
{
    static void Main()
    {
        double valor1 = 12.7;
        double valor2 = 2.6;

        var operacoes = new Operacoes();

        var resultadoSoma = operacoes.Somar(valor1, valor2);
        Console.WriteLine($"Resultado da soma: {resultadoSoma}");

        var resultadoSubtracao = operacoes.Subtrair(valor1, valor2);
        Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");

        var resultadoMultiplicacao = operacoes.Multiplicar(valor1, valor2);
        Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");

        try
        {
            var resultadoDivisao = operacoes.Dividir(valor1, valor2);
            Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        var resultadoMedia = operacoes.Media(valor1, valor2);
        Console.WriteLine($"Média: {resultadoMedia}");
    }
}

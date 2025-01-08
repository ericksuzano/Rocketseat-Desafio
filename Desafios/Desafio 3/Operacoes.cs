namespace Desafio_3;
public class Operacoes
{
    public double Somar(double valor1, double valor2)
    {
        var resultado = valor1 + valor2;
        return resultado;
    }

    public double Subtrair(double valor1, double valor2)
    {
        var resultado = valor1 - valor2;
        return resultado;
    }

    public double Multiplicar(double valor1, double valor2)
    {
        var resultado = valor1 * valor2;
        return resultado;
    }

    public double Dividir(double valor1, double valor2)
    {
        if (valor2 == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        var resultado = valor1 / valor2;
        return resultado;
    }

    public double Media(double valor1, double valor2)
    {
        var resultado = (valor1 + valor2) / 2;
        return resultado;
    }
}

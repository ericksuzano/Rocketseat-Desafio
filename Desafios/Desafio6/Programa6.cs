using System.Globalization;

namespace Desafio6;

class Programa6
{
    static void Main()
    {
        DateTime hoje = DateTime.Now;
        string completo = hoje.ToString("F", new CultureInfo("pt-BR"));
        string apenasData = hoje.ToString("d", new CultureInfo("pt-BR"));
        string apenasHora = hoje.ToString("HH:mm:ss", new CultureInfo("pt-BR"));
        string mesEmTexto = hoje.ToString("d MMMM yyyy", new CultureInfo("pt-BR"));
        
        Console.WriteLine(completo);
        Console.WriteLine(apenasData);
        Console.WriteLine(apenasHora);
        Console.WriteLine(mesEmTexto);
    }
}

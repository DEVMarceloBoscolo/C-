// CurrencyConverter - Conversor de Moedas
// Desenvolvido por marceloboscolo

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de Moedas (BRL/USD/EUR)");
        Console.Write("Valor em BRL: ");
        double brl = double.Parse(Console.ReadLine()!);

        Console.Write("Escolha a moeda de destino (USD/EUR): ");
        string moeda = Console.ReadLine()!.ToUpper();

        double resultado = moeda switch
        {
            "USD" => brl / 5.0,
            "EUR" => brl / 6.0,
            _ => 0
        };

        if (resultado > 0)
            Console.WriteLine($"{brl} BRL = {resultado:F2} {moeda}");
        else
            Console.WriteLine("Moeda inválida.");
    }
}

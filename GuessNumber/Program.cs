// GuessNumber - Jogo de Adivinhação
// Desenvolvido por marceloboscolo

using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int palpite, tentativas = 0;

        Console.WriteLine("Adivinhe o número de 1 a 100!");

        do
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine()!);
            tentativas++;
            if (palpite < numeroSecreto) Console.WriteLine("Mais alto!");
            else if (palpite > numeroSecreto) Console.WriteLine("Mais baixo!");
        } while (palpite != numeroSecreto);

        Console.WriteLine($"Parabéns! Número correto em {tentativas} tentativas.");
    }
}

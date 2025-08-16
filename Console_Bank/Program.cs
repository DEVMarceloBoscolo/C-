// Console Bank - Sistema Bancário Simples
// Desenvolvido por marceloboscolo

using System;
using System.Collections.Generic;

class Conta
{
    public string Nome { get; set; }
    public double Saldo { get; set; } = 0;
}

class Program
{
    static List<Conta> contas = new List<Conta>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n1- Criar Conta\n2- Depositar\n3- Sacar\n4- Consultar Saldo\n0- Sair");
            opcao = int.Parse(Console.ReadLine()!);
            switch(opcao)
            {
                case 1: CriarConta(); break;
                case 2: Depositar(); break;
                case 3: Sacar(); break;
                case 4: ConsultarSaldo(); break;
            }
        } while(opcao != 0);
    }

    static void CriarConta()
    {
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine()!;
        contas.Add(new Conta { Nome = nome });
        Console.WriteLine("Conta criada com sucesso!");
    }

    static void Depositar()
    {
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine()!;
        var conta = contas.Find(c => c.Nome == nome);
        if (conta != null)
        {
            Console.Write("Valor do depósito: ");
            conta.Saldo += double.Parse(Console.ReadLine()!);
            Console.WriteLine("Depósito realizado!");
        }
        else Console.WriteLine("Conta não encontrada.");
    }

    static void Sacar()
    {
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine()!;
        var conta = contas.Find(c => c.Nome == nome);
        if (conta != null)
        {
            Console.Write("Valor do saque: ");
            double valor = double.Parse(Console.ReadLine()!);
            if (valor <= conta.Saldo)
            {
                conta.Saldo -= valor;
                Console.WriteLine("Saque realizado!");
            }
            else Console.WriteLine("Saldo insuficiente.");
        }
        else Console.WriteLine("Conta não encontrada.");
    }

    static void ConsultarSaldo()
    {
        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine()!;
        var conta = contas.Find(c => c.Nome == nome);
        if (conta != null)
            Console.WriteLine($"Saldo de {conta.Nome}: {conta.Saldo:C}");
        else Console.WriteLine("Conta não encontrada.");
    }
}

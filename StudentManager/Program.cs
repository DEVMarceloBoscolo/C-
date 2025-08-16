// StudentManager - Gerenciamento de Alunos
// Desenvolvido por marceloboscolo

using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n1- Adicionar Aluno\n2- Listar Alunos\n3- Adicionar Nota\n4- Média\n0- Sair");
            opcao = int.Parse(Console.ReadLine()!);
            switch(opcao)
            {
                case 1: AdicionarAluno(); break;
                case 2: ListarAlunos(); break;
                case 3: AdicionarNota(); break;
                case 4: MediaAlunos(); break;
            }
        } while(opcao != 0);
    }

    static void AdicionarAluno()
    {
        Console.Write("Nome do aluno: ");
        alunos.Add(new Aluno { Nome = Console.ReadLine()! });
        Console.WriteLine("Aluno adicionado!");
    }

    static void ListarAlunos()
    {
        Console.WriteLine("Alunos:");
        foreach(var a in alunos)
            Console.WriteLine(a.Nome);
    }

    static void AdicionarNota()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine()!;
        var aluno = alunos.Find(a => a.Nome == nome);
        if (aluno != null)
        {
            Console.Write("Nota: ");
            aluno.Notas.Add(double.Parse(Console.ReadLine()!));
            Console.WriteLine("Nota adicionada!");
        }
        else Console.WriteLine("Aluno não encontrado.");
    }

    static void MediaAlunos()
    {
        foreach(var a in alunos)
        {
            double media = a.Notas.Count > 0 ? a.Notas.Average() : 0;
            string status = media >= 6 ? "Aprovado" : "Reprovado";
            Console.WriteLine($"{a.Nome} - Média: {media:F2} - {status}");
        }
    }
}

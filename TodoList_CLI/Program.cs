// TodoList CLI - Gerenciador de Tarefas
// Desenvolvido por marceloboscolo

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> tarefas = new List<string>();
    const string arquivo = "tarefas.txt";

    static void Main()
    {
        if (File.Exists(arquivo))
            tarefas.AddRange(File.ReadAllLines(arquivo));

        int opcao;
        do
        {
            Console.WriteLine("\n1- Adicionar Tarefa\n2- Listar Tarefas\n3- Remover Tarefa\n0- Sair");
            opcao = int.Parse(Console.ReadLine()!);
            switch(opcao)
            {
                case 1: AdicionarTarefa(); break;
                case 2: ListarTarefas(); break;
                case 3: RemoverTarefa(); break;
            }
        } while(opcao != 0);

        File.WriteAllLines(arquivo, tarefas);
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a tarefa: ");
        tarefas.Add(Console.ReadLine()!);
        Console.WriteLine("Tarefa adicionada!");
    }

    static void ListarTarefas()
    {
        Console.WriteLine("Tarefas:");
        for (int i = 0; i < tarefas.Count; i++)
            Console.WriteLine($"{i+1}. {tarefas[i]}");
    }

    static void RemoverTarefa()
    {
        ListarTarefas();
        Console.Write("Número da tarefa a remover: ");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0 && num <= tarefas.Count)
        {
            tarefas.RemoveAt(num - 1);
            Console.WriteLine("Tarefa removida!");
        }
        else Console.WriteLine("Número inválido.");
    }
}

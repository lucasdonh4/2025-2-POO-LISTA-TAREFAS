using System;
using System.Collections.Generic;

namespace tarfas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var operacoes = new Operacoes();

            Console.WriteLine("=== LISTA DE TAREFAS ===");
            try
            {
                IList<Tarefa> lista = operacoes.Listar();
                foreach (var tarefa in lista)
                {
                    Console.WriteLine($"{tarefa.Id} - {tarefa.Nome} ({tarefa.Status})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

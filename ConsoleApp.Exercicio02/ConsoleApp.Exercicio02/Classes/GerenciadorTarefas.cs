using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public class GerenciadorTarefas
    {
        Dictionary<Categoria, List<Tarefa>> tarefaLista;

        public GerenciadorTarefas()
        {
            tarefaLista = new Dictionary<Categoria, List<Tarefa>>();
        }

        public void AdicionarTarefa(Categoria categoria, Tarefa tarefa)
        {
            if(!tarefaLista.ContainsKey(categoria))
            {
                tarefaLista[categoria] = new List<Tarefa>();
            }
            tarefaLista[categoria].Add(tarefa);

            //Console.WriteLine($"Categoria {categoria.Nome}, recebeu a Tarefa: {tarefaLista.Keys}");
        }

        public void RemoverTarefa(Categoria categoria, Tarefa tarefa)
        {
            if (tarefa.concluida = false )
            {
                Console.WriteLine($"Tarefa {tarefa.descricao}, não pode ser removida, ainda não foi concluída.");
            }
            else 
            {
                if(!tarefaLista.ContainsKey(categoria))
                {
                    tarefaLista[categoria].Remove(tarefa);
                }
            }
        } 
        public void ListarTarefas(Categoria categoria, Tarefa tarefa)
        {
            if(!tarefaLista.ContainsKey(categoria))
            {
                foreach (var itemLista in tarefaLista)
                {
                    Console.WriteLine($"Categoria {categoria}, tarefa listada: {itemLista.Key}");
                }
            }
            
        }

        public void GerarRelatorio(Categoria categoria, Tarefa tarefa)
        {
            if(!tarefaLista.ContainsKey(categoria) == false)
            {
                Console.WriteLine("Sem tarefas para exibir");
            }
            else
            {
                foreach (var itemLista in tarefaLista)
                {
                    Console.WriteLine($"{itemLista.Key}");
                }
            }

        }
    }
}
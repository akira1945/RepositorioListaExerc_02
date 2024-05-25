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
            if (!tarefa.Concluida)
            {
                Console.WriteLine($"Tarefa {tarefa.Descricao}, não pode ser removida, ainda não foi concluída.");
            }
            else 
            {
                if(!tarefaLista.ContainsKey(categoria))
                {
                    tarefaLista[categoria].Remove(tarefa);
                }
            }
        } 
        public void ListarTarefas(Categoria categoria)
        {
            if(!tarefaLista.ContainsKey(categoria))
            {
                foreach (var item in tarefaLista[categoria])
                {
                    Console.WriteLine($"Categoria {categoria}, {item.Descrever()}");
                }
            }else{
                Console.WriteLine($"Categoria {categoria}, não existe.");
            }
            
        }

        public void GerarRelatorio()
        {
            foreach (var categoria in tarefaLista.Keys)
            {
                Console.WriteLine($"Categoria: {categoria.Nome}");
                foreach (var tarefa in tarefaLista[categoria])
                {
                    Console.WriteLine($"{tarefa.Descrever()}");
                }
            }

        }
    }
}
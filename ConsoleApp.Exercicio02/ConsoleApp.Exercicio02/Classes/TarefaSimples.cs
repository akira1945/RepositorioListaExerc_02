using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public class TarefaSimples : Tarefa
    {
        public TarefaSimples(string descricao, bool concluida) : base(descricao, concluida)
        {
            
        }

        public override string DescreverTarefa(string nomeTarefa)
        {
            Console.WriteLine("Bem vindo ao seu descritor de tarefas!");
            Console.WriteLine("Pressione qualquer tecla para começar:");
            nomeTarefa = Console.ReadLine()!;
            return nomeTarefa;
                        
        }

        public override void ConcluirTarefa(DateTime prazoConclusao)
        {   
            if (this.concluida = false)
            {
                Console.WriteLine($"Tarefa {descricao} não concluída.");
            }
            else
            {
                Console.WriteLine($"Tarefa {descricao} finalizada.");
            }
            
        }

       
    }
}
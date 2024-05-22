using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public class TarefaComPrazo : Tarefa
    {
        
        public DateTime DataPrazo { get; set; }
        
        public TarefaComPrazo(string descricao, bool concluida, DateTime prazo) : base(descricao, concluida)
        {
            this.DataPrazo = prazo;
        }

        public override string DescreverTarefa(string nomeTarefa)
        {
            Console.WriteLine("Bem vindo ao seu descritor de tarefas!");
            Console.WriteLine("Pressione qualquer tecla para começar:");
            nomeTarefa = Console.ReadLine()!;
            return nomeTarefa;
                                           
        }
         

        public override void ConcluirTarefa( DateTime prazoConclusao)
        {   
            prazoConclusao = prazoConclusao.AddDays(2);
            if (this.concluida = false )
            {
                Console.WriteLine($"Tarefa {descricao} não concluída.");
            }
            else if (this.concluida = true && DataPrazo < prazoConclusao )
            {
                Console.WriteLine($"Tarefa {descricao} concluída, com atrasos.");
            }
            else if (this.concluida = true && DataPrazo == prazoConclusao )
            {
                Console.WriteLine($"Tarefa {descricao} concluída, dentro do prazo estimado.");
            }
            else if (this.concluida = true && DataPrazo > prazoConclusao )
            {
                Console.WriteLine($"Tarefa {descricao} concluída, não atendeu ao prazo estimado.");
            }
                        
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public class TarefaComPrazo : Tarefa
    {
        
        public DateTime DataPrazo { get; set; }
        
        public TarefaComPrazo(string descricao, DateTime prazo) : base(descricao)
        {
            this.DataPrazo = prazo;
        }

        public override string Descrever()
        {
             return $"Tarefa tarefa com prazo: {Descricao} Prazo: {DataPrazo} ";                           
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public class TarefaSimples : Tarefa
    {
        public TarefaSimples(string descricao) : base(descricao)
        {
            
        }

        public override string Descrever()
        {
            return $"Tarefa simples: {Descricao}";               
        }

    }
}
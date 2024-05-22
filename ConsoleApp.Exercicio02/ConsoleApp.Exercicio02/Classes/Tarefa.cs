using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public abstract class Tarefa
    {
        private string Descricao;

        private bool Concluida;

        public string descricao { get{ return Descricao; }  set{ Descricao = value;} }

        public bool concluida { get{ return Concluida; } set{Concluida = value;} }

        public Tarefa(string descricao, bool concluida) 
        {
            this.descricao = descricao;
            this.concluida = concluida;
        }

        public abstract void ConcluirTarefa( DateTime prazoConclusao);

        public abstract string DescreverTarefa( string nomeTarefa);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercicio02.Classes
{
    public abstract class Tarefa
    {
        /*private string Descricao;

        private bool Concluida;

        public string descricao { get{ return Descricao; }  set{ Descricao = value;} }

        public bool concluida { get{ return Concluida; } set{Concluida = value;} }*/

        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(string descricao) 
        {
            this.Descricao = descricao;
            this.Concluida = false;
        }

       // public abstract void Concluir();
        public void Concluir()
        {   
            Concluida = true;
        }      
        
        public abstract string Descrever();

    }
}
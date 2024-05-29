using System.Dynamic;
using ConsoleApp.Exercicio02.Classes;

public class Program
{
    public static void Main (string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("AAAA");
        GerenciadorTarefas gerenciador = new GerenciadorTarefas();
        Categoria todo  = new Categoria("TODOS");
        Categoria doing = new Categoria("DOING");
        Categoria done  = new Categoria("DONE") ;

        Console.WriteLine("AAAA");
        GerenciadorTarefas gerenciador1 = new GerenciadorTarefas();
        Categoria tod  = new Categoria("TODOS");
        Categoria dong = new Categoria("DOING");
        Categoria doe  = new Categoria("DONE") ;

        gerenciador.AdicionarTarefa(todo, new TarefaComPrazo("Ir no banco resolver pipino", new DateTime()));
        gerenciador.AdicionarTarefa(doing, new TarefaSimples("Ministrar aula de .NET"));
        gerenciador.GerarRelatorio();
    }
}
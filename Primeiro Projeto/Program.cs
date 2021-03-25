using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno(1234,"Ana Maria",19);

            Aluno A2 = new Aluno();

            Console.WriteLine("Digite sua matricula");
            A2.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome");
            A2.Nome = (Console.ReadLine());
            
            Console.WriteLine("Digite sua idade");
            A2.Idade = int.Parse(Console.ReadLine());

            A1.fazerNiver();

            Console.WriteLine("Nome--> "+A1.Nome+", idade: "+A1.Idade);
            Console.WriteLine("Nome--> "+A2.Nome+", idade: "+A2.Idade);
        }
    }
}

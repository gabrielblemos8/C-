using System;

namespace Atividade_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();
            Funcionario2 F2 = new Funcionario2();
            
            Console.WriteLine("Digite o nome do primeiro Funcionario:");
            F1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            F1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo Funcionario:");
            F2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            F2.Salario = int.Parse(Console.ReadLine());
            
            double Media = (F1.Salario + F2.Salario) /2;

            Console.WriteLine("Primeiro Funcionario:");
            Console.WriteLine("Nome: " + F1.Nome);
            Console.WriteLine("Salario: " + F1.Salario);
           
            Console.WriteLine("Segundo Funcionario:");
            Console.WriteLine("Nome: " + F2.Nome);
            Console.WriteLine("Salario: " + F2.Salario);
            
            Console.WriteLine("Media de salario: " + Media);
                        
        }
    }
}
 
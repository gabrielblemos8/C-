using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lista_2
{
    class Program
    {   
        public static void Main(string[] args)
        {
            List<Funcionario> List = new List<Funcionario>();

            Funcionario f1 = new Funcionario(333,"Maria Brown", 4000);
            Funcionario f2 = new Funcionario(536,"Alex Grey", 3000);
            Funcionario f3 = new Funcionario(772,"Bob Green", 5000);

            List.Add(f1);
            List.Add(f2);
            List.Add(f3);


            Console.WriteLine("Digite o ID do funcionario");
            int searchId = int.Parse(Console.ReadLine());

            foreach (Funcionario item in List)
            {
                // se o id que o usuario entrou for igual o id do objeto do respectivo loop, imprima
                if (searchId == item.Id){
                    item.IncrementoSalario();
                    Console.WriteLine( "\r\n"+ $"id - {item.Id}, Nome - {item.Nome}, Salario Atualizado - R${item.Salario}");
                }
            }
        }
    }
}

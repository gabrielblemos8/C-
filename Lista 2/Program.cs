using System;
using System.Globalization;
using System.Collections.Generic;

/**https://github1s.com/acenelio/list1-csharp/blob/HEAD/Course/Employee.cs**/

namespace Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //nao utilize letras maiusculas nessas variaveis, leia as conveções de código do csharp
            // https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/coding-conventions
            List<Funcionario> list = new List<Funcionario>();

            Funcionario f1 = new Funcionario(333,"Maria Brown", 4000);
            Funcionario f2 = new Funcionario(536,"Alex Grey", 3000);
            Funcionario f3 = new Funcionario(333,"Bob Green", 5000);

            list.Add(f1);
            list.Add(f2);
            list.Add(f3);


            Console.WriteLine("Digite o ID do funcionario");
            int searchId = int.Parse(Console.ReadLine());

            
            //cada objeto da List "lista" é armazenado em item (uma var do tipo Funcionario) em cada loop, em sequencia de fila
            foreach (Funcionario item in list)
            {
                // se o id que o usuario entrou for igual o id do objeto do respectivo loop, imprima
                if (searchId == item.Id)
                    Console.WriteLine($"id - {item.Id} / nome - {item.Nome} / salario - {item.Salario}");
            }
        }
    }
}

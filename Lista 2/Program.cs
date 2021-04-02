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
            List<Funcionario> List = new List<Funcionario>();

            Funcionario f1 = new Funcionario(333,"Maria Brown", 4000);
            Funcionario f2 = new Funcionario(536,"Alex Grey", 3000);
            Funcionario f3 = new Funcionario(333,"Bob Green", 5000);

            List.Add(f1);
            List.Add(f2);
            List.Add(f3);


            Console.WriteLine("Digite o ID do funcionario");
            int searchId = int.Parse(Console.ReadLine());


            
            foreach (Funcionario x in List)
            {  
               
                Console.WriteLine();
            }




        }
    }
}

using System;

namespace Atividade_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.WriteLine("Digite o nome do Funcionario:");
            F.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            F.Salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto:");
            F.Imposto = int.Parse(Console.ReadLine());
           

            double SalarioLiquido = F.Salario - F.Imposto;

            Console.WriteLine("Funcionario: " + F.Nome + ",  $ " + SalarioLiquido);

            Console.WriteLine("Digite a porcentagem para aumentar o salario:");
            F.Porcentagem = int.Parse(Console.ReadLine());

            double NovoSalario = ((F.Porcentagem / 100) * F.Salario) + SalarioLiquido; // Porcentagem é o numero dividido por 100, multiplicado pelo valor inicial e somado ao novo valor, ou seja, 10/100 = 0,1*6000= 600 + 5000 = 5600 
            Console.WriteLine("Dados atualizados: " + F.Nome + ",  $ " + NovoSalario);

        }
    }
}

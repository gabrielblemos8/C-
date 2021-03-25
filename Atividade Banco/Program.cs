using System;

namespace Atividade_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente C = new Cliente();
            Cliente1 C1 = new Cliente1();

            int Deposito;
            int Sacar;

            Console.WriteLine("Conta 1");
            Console.WriteLine("\nDigite seu nome:");
            C.Nome = (Console.ReadLine());

            Console.WriteLine("Digite sua numero: ");
            C.Numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua saldo:");
            C.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("\nConta 2");
            Console.WriteLine("\nDigite seu nome: ");
            C1.Nome = (Console.ReadLine());

            Console.WriteLine("Digite sua numero: ");
            C1.Numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua saldo: ");
            C1.Saldo = double.Parse(Console.ReadLine());


            
            Console.WriteLine("\nSaldo atual: "+ C.Saldo);
            
            Console.WriteLine("\nDepositar: ");
            Deposito = int.Parse(Console.ReadLine());

            C.Saldo=C.Saldo + Deposito;

            Console.WriteLine("\nSaldo atualizado: "+ C.Saldo);
            Console.WriteLine("\nSacar: ");
            Sacar = int.Parse(Console.ReadLine());

            C.Saldo= C.Saldo - Sacar;

            Console.WriteLine("\nSaldo atualizado: "+ C.Saldo);

            Deposito = 0;
            Sacar = 0;

            Console.WriteLine("\nSaldo atual: "+ C1.Saldo);
            
            Console.WriteLine("\nSacar: ");
            Sacar = int.Parse(Console.ReadLine());

            C1.Saldo= C1.Saldo - Sacar;

            Console.WriteLine("\nSaldo atualizado: "+ C1.Saldo);
            Console.WriteLine("Depositar: ");
            Deposito = int.Parse(Console.ReadLine());

            C1.Saldo=C1.Saldo + Deposito;

            Console.WriteLine("\nSaldo atualizado: "+ C1.Saldo);
        }
    }
}

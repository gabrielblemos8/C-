using System;

using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluguel> list = new List<Aluguel>();

            Aluguel a1 = new Aluguel("Maria Green", "maria@gmail.com", 5);
            Aluguel a2 = new Aluguel("Marco Antonio", "marco@gmail.com", 1);
            Aluguel a3 = new Aluguel("Alex Brown", "alex@gmail.com", 8);

            list.Add(a1);
            list.Add(a2);
            list.Add(a3);

            Console.WriteLine("Quartos ocupados");
            foreach (Aluguel x in list)
            {
                Console.WriteLine("\r\n" +x.Quarto+ ": "+x.Nome+ ", "+x.Email);
            }

        }
    }
}

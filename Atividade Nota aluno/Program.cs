using System;

namespace Atividade_Nota_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double Media=0;

            Aluno A = new Aluno();

            Console.WriteLine("Digite seu nome");
            A.Nome = (Console.ReadLine());

            Console.WriteLine("Digite suas notas: ");
            A.Nota1 = double.Parse(Console.ReadLine());
            A.Nota2 = double.Parse(Console.ReadLine());
            A.Nota3 = double.Parse(Console.ReadLine());

            Media = A.Nota1+A.Nota2+A.Nota3;

            if(Media >= 60){
                Console.WriteLine("NOTA FINAL: " + Media);
                Console.WriteLine("APROVADO");
            }else{
                Console.WriteLine("NOTA FINAL: " + Media);
                Console.WriteLine("REPROVADO");
                Media=60-Media;
                Console.WriteLine("FALTARAM: " + Media);
            }

        }
    }
}

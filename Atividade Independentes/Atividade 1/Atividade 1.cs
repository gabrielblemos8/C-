
//Faça um programa que leia dois valores: A e B (positivos). 
//Se A for menor que B, calcule e imprima a soma dos números ímpares existente entre A(inclusive) e B (inclusive). 
//Se A for maior que B, calcule e imprima a média aritmética dos múltiplos de 3 existentes entre A(inclusive) e B(inclusive). 

//https://www.guj.com.br/t/exercicios-dificeis-sobre-c/355214

using System;
namespace Atividade_forum
{
    class Program
    {
        static void Main(string[] args)
        {   
            double i = 0;
            double A = 0;
            double B = 0;
            double soma = 0;
            double media = 0;
            int rep = 0; // quantidade de repetições para o calculo aritmética

            Console.WriteLine("Digite o primerio valor:");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            B = double.Parse(Console.ReadLine());

            if(A>0){
                if(B>0){
                    if(A<B){  //Se A for menor que B
                        for (i = A; i <= B; i++ ){
                            if (i % 2 != 0){
                                soma += i;                        
                            }                               
                        }
                        Console.WriteLine("Soma dos numeros impares é: " + soma);
                    }else{   //(A>B) Se A for maior que B
                        for (i = B; i <= A; i++ ){
                            if (i % 3 == 0){
                                soma += i;
                                rep += 1;                        
                            }                               
                        }
                        media = soma/rep;
                        Console.WriteLine("A média aritmética dos múltiplos de 3 é: " + media);
                    }
                }else{
                Console.WriteLine("Impossivel realizar com numero negativo!!");
            }
            }else{
                Console.WriteLine("Impossivel realizar com numero negativo!!");
            }
        }
    }
}

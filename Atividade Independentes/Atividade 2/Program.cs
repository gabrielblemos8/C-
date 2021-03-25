//Faça um programa que leia um valor A e um valor N. Calcule e imprima a soma dos N primeiros 
//números a partir de A (inclusive). Considere que não será lido um valor negativo para N.

using System;

//https://www.guj.com.br/t/exercicios-dificeis-sobre-c/355214

namespace Atividade_forum
{

class Atividade2
{
static void Main(string[] args)
{
    int A;
    int N;
    int i;
    int soma=0;
           
    Console.WriteLine("Digite o valor inicial:");
    A = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de numeros subsequentes á serem somados:");
    N = int.Parse(Console.ReadLine());
    soma = A;        
           
    if(N > 0){ 

        for(i = 0; i < N ; i ++){    
            if(i!=0){
                A+=1;                   
                soma += A ; 
            }
            
        }
        Console.WriteLine("\nA soma dos "+ N +" numeros subsequentes á "+ A + " é: " + soma );       
    }else{
        Console.WriteLine("\nAImpossivel calcular!! " );
    }
}
}
}

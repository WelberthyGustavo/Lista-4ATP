using System;
//Exercicio - 3

namespace Menor;

class MenorElemento{
    public static void Gerar(){
        int ele = 0;

        Console.WriteLine("Digite o numero de Elementos:");
        int num = int.Parse(Console.ReadLine());

        int[] vetor = new int[num - 1];

        for(int i = 0; i < vetor.Length; i++){
            Console.WriteLine($"Digite o o valor do {i + 1} Elemento:");
            ele = int.Parse(Console.ReadLine());
            vetor[i] = ele;
        }

        foreach(int number in vetor){
            Console.WriteLine(number);
        }

        Console.WriteLine($"Menor elemento foi: {Menor(vetor)}");

        
    }

    public static int Menor(int[] vetor){
        int menor = int.MaxValue;
        for(int i = 0; i < vetor.Length; i++){
            if(vetor[i] < menor) 
                menor = vetor[i];
        }
        return menor;
    }

}
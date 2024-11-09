using System.Globalization;
//Exercicio - 1

namespace Pares;

class ParesNumbers{
    public static int[] Numbers(){
        int[] Numbers = new int[14];
         
        Random random = new Random();
         
        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = random.Next(1, 101);  
        }

        Console.WriteLine("Números aleatórios no vetor:");
        foreach (int numero in Numbers)
        {
            Console.WriteLine(numero);
        }

        Pares(Numbers);

        return Numbers;
    }

    public static int[] Pares(int[] vetor){

        int[] newVetor = new int[(vetor.Length + 1) / 2];
        int j = 0;
        for(int i = 0; i < vetor.Length; i++){
            if(i % 2 == 0){
                newVetor[j] = vetor[i];
                j++;
            }
        }

        Console.WriteLine("Números na posições pares:");

        foreach (int num in newVetor)
        {
            Console.WriteLine(num);
        }
        
        return newVetor;
      
    }
}
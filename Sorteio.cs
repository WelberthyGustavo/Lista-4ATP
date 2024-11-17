using System;
// Exercicio - 5

namespace Sorteio;

public class SorteioNumeros{

    public static void Jogar(){

        int[] numSort = new int[5];
        numSort = Sortear();
        bool found = false;

        while(found == false){
            Console.WriteLine("Digite um numero de 10 a 30:");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < numSort.Length; i++){
                if(num == numSort[i]){
                    Console.WriteLine($"Voce acertou o numero sorteado: {numSort[i]}");
                    found = true;
                }
            }
        }

    }

    public static int[] Sortear(){

        int[] numbers = new int[5];

        Random random = new Random();

        for(int i = 0; i < numbers.Length; i++){
            numbers[i] = random.Next(10, 31);
        }

        return numbers;

    }

}
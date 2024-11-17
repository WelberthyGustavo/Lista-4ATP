using System;
// Exercicio - 4

namespace Vetores;

public class UnirVetores{
    public static void GerarVetores(){

        int[] x = new int[10];
        int[] y = new int[10];
        int[] z = new int[20];

        Random random = new Random();

        Console.WriteLine("Primeiro vetor:");
        for(int i = 0; i < x.Length; i++){
            x[i] = random.Next(1, 101);
            Console.WriteLine(x[i]);
        }

        Console.WriteLine("Segundo vetor:");
        for(int i = 0; i < x.Length; i++){
            y[i] = random.Next(1, 101);
            Console.WriteLine(y[i]);
        }

        z = Unir(x, y);

        Console.WriteLine("Novo vetor:");
        for(int i = 0; i < z.Length; i++){
            Console.WriteLine(z[i]);
        }
    }

    public static int[] Unir(int[] x, int[] y){

    int[] z = new int[x.Length + y.Length]; 
    int j = 0;

    for (int i = 0; i < z.Length; i++){

        if (i % 2 == 0){
            z[i] = y[j];
        }
        else{
            z[i] = x[j];
            j++; 
        }
    }

    return z;
}

}
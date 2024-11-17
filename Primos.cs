using System;
//Exercicio - 7

namespace Primos;

class MatrizPrimos{
    public static void GerarMatriz(){

        int[,] num = new int[3, 3];

        Random random = new Random();

        for (int i = 0; i < num.GetLength(0); i++){
            for (int j = 0; j < num.GetLength(1); j++){
                num[i, j] = random.Next(1, 31);
                Console.Write($"{num[i, j],3}");
            }
            Console.WriteLine();
        }

        NumPrimos(num);
    }

    public static void NumPrimos(int[,] numeros){

        int[,] num = numeros;
        int[] numPri = new int[num.Length]; 
        int p = 0;
        int somaPrimos = 0;  

        for (int i = 0; i < num.GetLength(0); i++){
            for (int j = 0; j < num.GetLength(1); j++){
                int n = num[i, j];  
                bool isPrimo = true;  

                if (n <= 1){
                    isPrimo = false;
                }
                else{
                    for (int k = 2; k < n; k++){
                        if (n % k == 0){
                            isPrimo = false;
                            break;  
                        }
                    }
                }

                if (isPrimo){
                    numPri[p] = n;
                    Console.WriteLine(numPri[p]);
                    somaPrimos += n;  
                    p++;  
                }
            }
        }

        Console.WriteLine($"A soma dos números primos é: {somaPrimos}");
    }
}
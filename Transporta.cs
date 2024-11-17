using System;
//Exercise - 9

namespace Transposta;

class MatrizT{
    
    public static void PreencherMatriz(int[,] M){
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                M[i, j] = random.Next(-10, 11); 
            }
        }
    }

    
    public static int[,] MatrizTransposta(int[,] M){
        int[,] AT = new int[3, 3];  

        for (int i = 0; i < 3; i++){
            for (int j = 0; j < 3; j++){
                AT[j, i] = M[i, j]; 
            }
        }

        return AT;
    }

    public static void ExibirMatriz(int[,] M){
        for (int i = 0; i < 3; i++){
            for (int j = 0; j < 3; j++)
            {
                Console.Write(M[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void GerarMatrizEExibirTransposta(){
        int[,] M = new int[3, 3];  

        PreencherMatriz(M);

        Console.WriteLine("Matriz Original:");
        ExibirMatriz(M);

        int[,] AT = MatrizTransposta(M);

        Console.WriteLine("\nMatriz Transposta:");
        ExibirMatriz(AT);
    }
}



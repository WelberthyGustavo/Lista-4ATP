using System;
//Exercicio - 10

namespace TrocaMatriz;

class MatrizTroca{
    public static void PreencherMatriz(int[,] M){
        Random random = new Random();

        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                M[i, j] = random.Next(-10, 11);  
            }
        }
    }

    public static void ExibirMatriz(int[,] M){
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                Console.Write(M[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Função para trocar a linha 2 com a linha 8
    public static void TrocarLinha2ComLinha8(int[,] M){
        for (int j = 0; j < 10; j++){
            int temp = M[1, j]; 
            M[1, j] = M[7, j];  
            M[7, j] = temp;
        }

        Console.WriteLine("Matriz após trocar linha 2 com linha 8:");
        ExibirMatriz(M);
    }

    public static void TrocarColuna4ComColuna10(int[,] M){
        for (int i = 0; i < 10; i++){
            int temp = M[i, 3];  
            M[i, 3] = M[i, 9];  
            M[i, 9] = temp;
        }

        Console.WriteLine("Matriz após trocar coluna 4 com coluna 10:");
        ExibirMatriz(M);
    }


    public static void TrocarDiagonais(int[,] M){
        for (int i = 0; i < 10; i++){
            int temp = M[i, i];   
            M[i, i] = M[i, 9 - i];  
            M[i, 9 - i] = temp;
        }

        Console.WriteLine("Matriz após trocar diagonais:");
        ExibirMatriz(M);
    }

    public static void GerarMatrizETrocar(){
        int[,] M = new int[10, 10];  

        PreencherMatriz(M);
        Console.WriteLine("Matriz Original:");
        ExibirMatriz(M);
        TrocarLinha2ComLinha8(M);
        TrocarColuna4ComColuna10(M);
        TrocarDiagonais(M);
    }
}

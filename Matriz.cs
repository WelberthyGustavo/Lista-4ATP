using System;
//Exercicio - 8

namespace Matriz;


class MatrizGerar{

    public static void PreencherMatriz(int[,] M){
        Random random = new Random();

        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 5; j++){
                M[i, j] = random.Next(1, 101); 
                Console.Write($"{M[i, j],3}");
            }
            Console.WriteLine();
        }
    }

    public static int SomaLinha3(int[,] M){
        int soma = 0;
        for (int j = 0; j < 5; j++){
            soma += M[2, j];  
        }
        Console.WriteLine($"Soma da linha 3: {soma}");
        return soma;
    }

    public static int SomaColuna2(int[,] M){
        int soma = 0;
        for (int i = 0; i < 5; i++){
            soma += M[i, 1];  
        }
        Console.WriteLine($"Soma da coluna 2: {soma}");
        return soma;
    }

    public static int SomaDiagonalPrincipal(int[,] M)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++){
            soma += M[i, i]; 
        }
        Console.WriteLine($"Soma da diagonal principal: {soma}");
        return soma;
    }

    public static int SomaDiagonalSecundaria(int[,] M){
        int soma = 0;
        for (int i = 0; i < 5; i++){
            soma += M[i, 4 - i];  
        }
        Console.WriteLine($"Soma da diagonal secundária: {soma}");
        return soma;
    }

    public static int SomaTotal(int[,] M){
        int soma = 0;
        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 5; j++){
                soma += M[i, j]; 
            }
        }
        Console.WriteLine($"Soma de todos os elementos: {soma}");
        return soma;
    }

    public static void GerarMatrizEExibirSomas(){
        int[,] M = new int[5, 5];  
        PreencherMatriz(M);

        SomaLinha3(M);
        SomaColuna2(M);
        SomaDiagonalPrincipal(M);
        SomaDiagonalSecundaria(M);
        SomaTotal(M);
    }
}


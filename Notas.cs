using System;
//Exercicio - 2

namespace Notas;

class NotasDaTurma(){
    public static void GerarNotas(){

        double[] notas = new double[10];
        Random random = new Random();

        for(int i = 0; i < notas.Length; i++){
            notas[i] = random.Next(1, 101);
            Console.WriteLine(notas[i]);
        }

        Media(notas);
    }

    public static void Media(double[] vetor){

        double[] notas = new double[vetor.Length];
        double soma = 0;
        double media = 0;
        int numerosAlunos = 0;

        for(int i = 0; i < notas.Length; i++){
            notas[i] = vetor[i];
        }

        for(int i = 0; i < notas.Length; i++){
            soma += notas[i];
        }

        media = soma / notas.Length;

        for(int i = 0; i < notas.Length; i++){
            if(notas[i] >= media){
                numerosAlunos++;
            }
        }
        Console.WriteLine($"Numero da media das notas dos alunos foi: {media}");
        Console.WriteLine($"Numero de Alunos acima da media foi: {numerosAlunos}");
        
    }


}
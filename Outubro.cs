using System;
//Exercicio - 6

namespace Outubro;

class TemperaturaOutubro{
    public static void Temperaturas(){

        int[] dias = new int[31];

        Random random = new Random();

        for(int i = 0; i < dias.Length; i++){
            dias[i] = random.Next(15, 41);
        }

        foreach (int temperaturas in dias){
            Console.WriteLine(temperaturas + " °C");
        }

        Analises(dias);

    }

    public static void Analises(int[] days){


        int[] temp = days;
        int maiorT = int.MinValue;
        int menorT = int.MaxValue;
        int soma = 0;
        int media = 0;
        int menorMedia = 0;


        for(int i = 0; i < temp.Length; i++){
            if(temp[i] < menorT){
                menorT = temp[i];
            }
            if(temp[i] > maiorT){
                maiorT = temp[i];
            }
        }

        for(int i = 0; i < temp.Length; i++){
            soma += temp[i];
        }

        media = soma / temp.Length;
        
        for(int i = 0; i < temp.Length; i++){
            if(temp[i] < media){
                menorMedia++;
            }
        }

        Console.WriteLine($"A menor Temperatura foi: {menorT} °C, A maior temperatura foi: {maiorT} °C");
        Console.WriteLine($"A Temperatura media foi: {media} °C");
        Console.WriteLine($"A quantidade de dias inferiores a temperatura media foi: {menorMedia} dias");
    }


}
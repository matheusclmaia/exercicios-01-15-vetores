using System.ComponentModel.DataAnnotations;
using System.Globalization;
internal class Program
{
    //Faça um programa que leia N números inteiros e armazene-os em um vetor.Em seguida, mostre na tela:
    //- todos os números pares
    //- a quantidade de números pares
    //Exemplos:
    //Entrada: 6  -  8 2 11 14 13 20
    //Saida    8 2 14 20    -    4
    private static void Main(string[] args)
    {
        int N,contagem=0,m=0;
        string[] vet;
        int[] valores, pares;

        N = int.Parse(Console.ReadLine());
        valores = new int[N];

        vet = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            valores[i] = int.Parse(vet[i]);
            if (valores[i] % 2 == 0)
            { 
            contagem++;
            }
        }
        
        pares = new int[contagem];

        for (int i = 0; i < N; i++)
        {
            if (valores[i] % 2 == 0)
            { 
            pares[m] = valores[i];
            Console.Write(pares[m]+ " ");
            m++;
            }
        }
        Console.WriteLine("\n"+contagem);



        Console.ReadKey();
    }
}
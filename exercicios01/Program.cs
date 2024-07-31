using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
internal class Program
{
    //Faça um programa para ler dois vetores A e B, contendo N elementos cada.Em seguida, gere um terceiro vetor C onde
    //cada elemento de C é a soma dos elementos correspondentes de A e B.Imprima o vetor C gerado.
    //Entrada
    //6
    //8 2 11 14 13 20
    //5 10 3 1 10 7

    //Saída
    //13 12 14 15 23 27


    private static void Main(string[] args)
    {
        int N;
        string[] vet;
        int[] valor1, valor2, resultado;

        N = int.Parse(Console.ReadLine());
        valor1 = new int[N];
        valor2 = new int[N];
        resultado = new int[N];
        vet = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            valor1[i] = int.Parse(vet[i]);
        }
        vet = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            valor2[i] = int.Parse(vet[i]);
        }
        for (int i = 0; i < N; i++)
        {
            resultado[i] = valor1[i] + valor2[i];
            Console.Write(resultado[i]+ " ");
        }

        Console.ReadKey();
    }
}
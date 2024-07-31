using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
internal class Program
{
    // Numero 4

    //Fazer um programa para ler um vetor de N números reais. Em seguida,
    //- Mostrar na tela a média aritmética de todos elementos
    //- Depois mostrar todos os elementos do vetor que estejam abaixo da média.

    //Entrada
    //4
    //10.0 15.5 13.2 9.8

    //Saída
    //12.125
    //10.0
    //9.8


    private static void Main(string[] args)
    {
        int N;
        string[] vet;
        double[] elementos;
        double media = 0.0;

        N = int.Parse(Console.ReadLine());
        elementos = new double[N];
        vet = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++) 
        {
            elementos[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            media = media + elementos[i];
        }
        media = media / N;
        Console.WriteLine(media);
        
        for (int i = 0; i< N; i++)
        {
            if (elementos[i] < media)
            {
                Console.WriteLine(elementos[i].ToString("F1"), CultureInfo.InvariantCulture);
            }
        }








        Console.ReadKey();
    }
}
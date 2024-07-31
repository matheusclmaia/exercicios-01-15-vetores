using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
internal class Program
{
    // Numero 5

    //Fazer um programa para ler um vetor de N números inteiros. Em seguida,
    // - mostrar na tela a média aritmética somente dos números pares lidos.

    //Entrada
    // 6 
    // 8 2 11 14 13 20 

    //Saída
    // 11.0


    private static void Main(string[] args)
    {
        int N, contador =0;
        string[] vet;
        double[] elementos;
        double media=0;

        N = int.Parse(Console.ReadLine());
        elementos = new double[N];
        vet = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            elementos[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);
        }
        for (int i = 0; i < N; i++)
        {
            if (elementos[i] % 2 == 0)
            {
                media = media + elementos[i];
                contador++;
            }
        }
        media = media / contador;

        Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));


        Console.ReadKey();
    }
}
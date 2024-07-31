using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    // Numero 8

    //Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
    // a maior e a menor altura do grupo
    // a média de altura das mulheres
    // o número de homens

    //Entrada:  5
    //1.70 F
    //1.83 M
    //1.54 M
    //1.61 F
    //1.75 F

    // Saída
    //Menor altura = 1.54
    //Maior altura = 1.83
    //Media das alturas das mulheres = 1.69
    //Numero de homens = 2


    private static void Main(string[] args)
    {
        int N, homens=0, mulher=0;
        double menor = double.MaxValue , maior = double.MinValue, mediamulheres=0;
        double[] altura;
        string[] sexo, vet;
        
      
        N = int.Parse(Console.ReadLine());

        altura = new double[N];
        sexo   = new string[N];

        for (int i = 0; i < N; i++)
        {
            vet = Console.ReadLine().Split(' ');
            altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
            sexo[i] = vet[1];
        }
        for (int i =0; i < N ; i++)
        { 

            //Menor altura
            if (altura[i] < menor)
            {
                menor = altura[i];
            }
            //Maior altura
            if (altura[i] > maior)
            {
                maior = altura[i];
            }
            // Altura media das mulheres
            if (sexo[i] == "F")
            {
                mediamulheres += altura[i];
                mulher++;
            }
            // Quantidade de homens
            if (sexo[i] == "M")
            {
                homens++;
            }
        }
        mediamulheres = mediamulheres / mulher;

        Console.WriteLine("Menos altura = " + menor.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Media das alturas das Mulheres = " + mediamulheres.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Numero de Homens = " + homens);


        Console.ReadKey();
    }
}
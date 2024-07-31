using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
internal class Program
{
    // Numero 7

    //Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. 
    //Cada uma dessas informações deve ser armazenada em um vetor.Depois, imprimir os nomes dos alunos aprovados,
    //considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.

    //Entrada:  4
    //Joao  7.0  8.5 
    //Maria  9.2  6.5 
    //Carlos  5.0  6.0 
    //Teresa  5.5  6.5 

    // Saída
    //Alunos aprovados: 
    //Joao
    //Maria
    //Teresa

    private static void Main(string[] args)
    {
        int N;
        double[] nota1, nota2, media;
        string[] vet, nome;

        N = int.Parse(Console.ReadLine());
        nota1 = new double[N];
        nota2 = new double[N];
        media = new double[N];
        nome = new string[N];

        
        for (int i = 0; i < N; i++)
        {
            vet = Console.ReadLine().Split(' ');
            nome[i] = vet[0];
            nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
            nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            media[i] = (nota1[i] + nota2[i])/2;
            
        }

        Console.WriteLine("Alunos aprovados:");
        for (int i = 0; i < N; i++) 
        {
           if (media[i] >= 6)
            {
                Console.WriteLine(nome[i]);
            }
        }


        Console.ReadKey();
    }
}
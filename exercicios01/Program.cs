using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
internal class Program
{
    // Numero 6

    //Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
    //da pessoa mais velha.
    // Entrada: 5
    //Joao 16
    //Maria 21
    //Teresa 15
    //Carlos 23
    //Paulo 17

    // Saída: Pessoa mais velha: Carlos

    private static void Main(string[] args)
    {
        int N, minimo = int.MinValue;
        int[] idade;
        string[] nome, vet;
        string velho="sem nome";

        N = int.Parse(Console.ReadLine());
        idade = new int[N];
        nome = new string[N];

        for (int i = 0; i<N;i++)
        {
            vet = Console.ReadLine().Split(' ');
            nome[i] = vet[0];
            idade[i] = int.Parse(vet[1]);
            
        }
        for (int i = 0; i < N; i++)
        {
            if (idade[i] > minimo)
            {
                minimo = idade[i];
                velho = nome[i];
            }
        }

        Console.WriteLine("Pessoa mais velha: " + velho);


        Console.ReadKey();
    }
}
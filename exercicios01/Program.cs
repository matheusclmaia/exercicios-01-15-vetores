using System.ComponentModel.DataAnnotations;
using System.Globalization;
internal class Program
{
    //Faça um programa que leia N números reais e armazene-os em um vetor.Em seguida, 
    //mostrar na tela o maior número do vetor(supor não haver empates).Mostrar também a posição do maior elemento.
    
    //Exemplo:
   
    //Entrada : 6   -   8.0 4.0 10.0 14.0 13.0 7.0
    
    //Saída: 14.0  3

    private static void Main(string[] args)
    {
        int N, local=0;
        string[] vet;
        double[] valores;
        double minimo = double.MinValue;

        N = int.Parse(Console.ReadLine());
        valores = new double[N];
        vet = Console.ReadLine().Split(' ');


        for (int i = 0; i < N; i++)
        {
            valores[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);
            Console.WriteLine(valores[i].ToString("F2"), CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < N; i++)
        {
            if (valores[i] > minimo)
            {
                minimo = valores[i];
                local = i;
            }
        }

        Console.WriteLine(minimo.ToString("F1"), CultureInfo.InvariantCulture);
        Console.WriteLine(local);



        Console.ReadKey();
    }
}
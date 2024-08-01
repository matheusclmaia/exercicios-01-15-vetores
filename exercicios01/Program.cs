using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    // Numero 9

    //Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar 
    //um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas.Fazer um
    //programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram: 
    // lucro< 10% 
    // 10% ≤ lucro ≤ 20% 
    // lucro> 20% 
    //Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.

    //Entrada 4
    // Feijao  10.00  11.00 
    // Arroz   12.00  12.80 
    // Oleo     5.00  5.70 
    // Sal      3.00 4.00 

    //Saída:
    //Lucro abaixo de 10%: 1 
    //Lucro entre 10% e 20%: 2 
    //Lucro acima de 20%: 1 
    //Valor total de compra: 30.00 
    //Valor total de venda: 33.50 
    //Lucro total: 3.50 


    private static void Main(string[] args)
    {
        int N, contador = 0;
        double[] compra, venda, lucro;
        string[] vet, produto;
        double totalcompra =0 , totalvenda=0;


        N = int.Parse(Console.ReadLine());

        compra  = new double[N];
        venda   = new double[N];
        produto = new string[N];
        lucro   = new double[N];
        

        for (int i = 0; i < N; i++)
        {
            vet = Console.ReadLine().Split(' ');
            produto[i] = vet[0];
            compra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
            venda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            lucro[i] = venda[i] - compra[i]  ;
            totalcompra += compra[i];
            totalvenda  += venda[i];
        }

        // Lucro abaixo de 10%
        for (int i = 0; i < N; i++)
        {

            if (lucro[i] < compra[i] * (0.1))
            {
                contador++;
            }
        }
        Console.WriteLine("\nLucro abaixo de 10 %: " + contador);
        contador = 0;

        //Lucro entre 10% e 20%: 
        for (int i = 0; i < N; i++)
        {
            if (lucro[i] >= compra[i] * (0.1) && lucro[i] <= compra[i] * (0.2))
            {
                contador ++;
            }
        }
        Console.WriteLine("Lucro entre 10% e 20%: " + contador);
        contador = 0;

        //Lucro acima de 20%: 
        for (int i = 0; i < N; i++)
        {
            if (lucro[i] > compra[i] * (0.2))
            {
                contador++;
            }
        }
        Console.WriteLine("Lucro acima de 20%: " + contador);
        contador = 0;

        //Valor total de compra: 30.00 
        //Valor total de venda: 33.50 
        //Lucro total: 3.50 
        Console.WriteLine("Valor total de compra: " + totalcompra.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Valor total de venda: " + totalvenda.ToString("F2", CultureInfo.InvariantCulture));
        totalcompra = totalvenda - totalcompra;
        Console.WriteLine("Lucro total: " + totalcompra.ToString("F2", CultureInfo.InvariantCulture));


        Console.ReadKey();
    }
}
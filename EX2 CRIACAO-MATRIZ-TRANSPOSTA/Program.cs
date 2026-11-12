/* 
 2. Criação de Matriz Transposta
Escreva um programa que crie automaticamente uma matriz de números inteiros de dimensão 3x5.
Em seguida, utilizando os elementos da matriz original, gere uma nova matriz de dimensão 5x3, representando sua matriz transposta. Ao final, exiba as duas matrizes.
 */

using System.Security.Cryptography;

int linha = 3;
int coluna = 5;
int[,] m1 = new int[linha, coluna];

void PopulaMatriz()
{
    Console.WriteLine($"Matriz:");
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
            Console.Write($"{m1[i, j]} ");
        }
        Console.WriteLine( );
    }
    Console.WriteLine();
}

void GerarMatrizInversa()
{
    int[,] m2 = new int[coluna, linha];
    Console.WriteLine($"Matriz Inversa:");
    for (int i = 0; i < coluna; i++)
    {
        for(int j =0; j < linha; j++)
        {
            m2[i, j] = m1[j, i];
            Console.Write($"{m2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void EspelhaMatriz()
{
    int[,] m3 = new int[linha,coluna];
    int contador = 0;
    int contador2 = 0;

    Console.WriteLine($"Matriz Espelhada:");
    for (int i=linha-1; i>=0; i--)
    {
        contador2 = 0;
        for (int j=coluna-1; j>=0; j--)
        {
            m3[contador, contador2] = m1[i,j];
            Console.Write($"{m3[contador, contador2]} ");
            contador2++;
            
        }
        contador++;
        Console.WriteLine();
    }
}




PopulaMatriz();
GerarMatrizInversa();
EspelhaMatriz();
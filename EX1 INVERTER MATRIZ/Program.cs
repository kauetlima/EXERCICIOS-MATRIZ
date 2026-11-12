/* 
 1. Preenchimento e Exibição de Matriz em Ordem Direta e Inversa
Escreva um programa que solicite ao usuário a quantidade de linhas e colunas de uma matriz de números inteiros. 
Em seguida, preencha a matriz automaticamente com valores gerados pelo programa e apresente seus elementos em duas ordens: do primeiro ao último elemento e do último ao primeiro.
 */


using System.Security.Cryptography;
int contador1 = 0;
int contador2 = 0;
int maior = 0;
Console.WriteLine("Escreva a quantidade de linhas da matriz:");
int linha = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva a quantidade de colunas da matriz:");
int coluna = int.Parse(Console.ReadLine());

int[,] m1 = new int[linha, coluna];

void PreencheValoresMatriz()
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void ImpreMatriz()
{
    Console.Write("Matriz Normal:");
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{m1[i, j]}] ");
        }
    }
}

void ImprimeMatrizInvertida()
{
    Console.Write("Invertida:");
    for (int i = linha-1; i >= 0; i--)
    {
        for (int j = coluna-1; j >= 0; j--)
        {
            Console.Write($"[{m1[i, j]}] ");
        }
    }
}

PreencheValoresMatriz();
ImpreMatriz();
ImprimeMatrizInvertida();

/*
3. Soma dos Elementos de uma Matriz Quadrada
Escreva um programa que solicite ao usuário o tamanho de uma matriz quadrada de números inteiros (a quantidade de linhas e colunas deverá ser igual). Em seguida, preencha a matriz automaticamente com valores gerados pelo programa e apresente:
- A soma dos elementos de cada linha.
- A soma dos elementos de cada coluna.
- A soma dos elementos da diagonal principal.
- A soma dos elementos da diagonal secundária (inversa).
Ao final, exiba a matriz e todos os resultados calculados.
*/

using System.Security.Cryptography;
using System.Xml;

Console.WriteLine("Digite o tamanho da sua matriz:");
int tamanho = int.Parse(Console.ReadLine());
int linha = tamanho;
int coluna = tamanho;
int[,] matriz = new int[linha, coluna];

void PopulaMatriz(int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 5);
        }
    }
}

void ImprimeMatriz(int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            Console.Write($"{matriz[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SomaDiagonalPrincipal(int[,] matriz, int linha, int coluna)
{
    int soma = 0;
    int guarda = 0;

    for (int i = 0; i < linha; i++)
    {
        guarda = matriz[i, i];
        soma += guarda;
    }
    Console.WriteLine($"O valor da soma da diagonal principal é: {soma}");
}

void SomaDiagonalSecundaria(int[,] matriz, int linha, int coluna)
{
    int soma = 0;
    int guarda = 0;
    int diagonal = coluna - 1;

    for (int i = 0; i < linha; i++)
    {
        guarda = matriz[i, diagonal];
        soma += guarda;
        diagonal--;
    }
    Console.WriteLine($"O valor da soma da diagonal secundária é: {soma}");
}

void SomaDasLinhas(int[,] matriz, int linha, int coluna) 
{
    int soma = 0;

    for (int i=0; i < linha; i++)
    {
        soma = 0;
        for (int j = 0; j < coluna; j++)
        {
            soma += matriz[i,j];
           
        }
        Console.WriteLine($"Soma da linha {i} : {soma}");
    }
}

void SomaDasColunas(int[,] matriz, int linha, int coluna)
{
    int soma = 0;

    for (int i = 0; i < linha; i++)
    {
        soma = 0;
        for (int j = 0; j < coluna; j++)
        {
            soma += matriz[j, i];

        }
        Console.WriteLine($"Soma da coluna {i} : {soma}");
    }
}


PopulaMatriz(matriz);
Console.WriteLine("Essa é a MATRIZ:");
ImprimeMatriz(matriz);
SomaDiagonalPrincipal(matriz, linha, coluna);
SomaDiagonalSecundaria(matriz, linha, coluna);
SomaDasLinhas(matriz, linha, coluna);
SomaDasColunas(matriz, linha, coluna);
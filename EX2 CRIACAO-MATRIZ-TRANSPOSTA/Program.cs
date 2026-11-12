
using System.Security.Cryptography;

int linha = 3;
int coluna = 5;

int[,] m1 = new int[linha, coluna];
int[,] m2 = new int[coluna, linha];
int[,] m3 = new int[linha, coluna];

void PopulaMatriz(int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void GerarMatrizTransposta(int[,] matriz, int[,] matrizTransposta, int coluna, int linha)
{
    for (int i = 0; i < coluna; i++)
    {
        for (int j = 0; j < linha; j++)
        {
            matrizTransposta[i, j] = matriz[j, i];
        }
    }
}

void EspelhaMatriz(int[,] matriz, int[,] matrizEspelhada, int linha, int coluna)
{
    int contador = 0;
    int contador2 = 0;

    for (int i = linha - 1; i >= 0; i--)
    {
        contador2 = 0;

        for (int j = coluna - 1; j >= 0; j--)
        {
            matrizEspelhada[contador, contador2] = matriz[i, j];
            contador2++;
        }

        contador++;
    }
}

void ImprimeMatriz(int[,] matriz, int linha, int coluna)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"{matriz[i, j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}



PopulaMatriz(m1);
GerarMatrizTransposta(m1, m2, coluna, linha);
EspelhaMatriz(m1, m3, linha, coluna);

Console.WriteLine("Matriz Original (3x5):");
ImprimeMatriz(m1, linha, coluna);

Console.WriteLine("Matriz Transposta (5x3):");
ImprimeMatriz(m2, coluna, linha);

Console.WriteLine("Matriz Espelhada (3x5):");
ImprimeMatriz(m3, linha, coluna);

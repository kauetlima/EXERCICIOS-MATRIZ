/*4. Geração de Boletim Escolar
Escreva um programa que gere o boletim escolar de um aluno utilizando uma matriz para armazenar suas informações acadêmicas.

A matriz deverá ser organizada da seguinte forma:
- Linhas: representam as disciplinas (matérias).
- Colunas: representam as notas obtidas em cada bimestre, a média final e a situação do aluno em cada disciplina.
O programa deverá solicitar as notas de cada disciplina, calcular automaticamente a média final e determinar a situação do aluno em cada matéria (aprovado ou reprovado)
considerando a média mínima definida pelo programa.

Ao final, apresente o boletim completo, contendo as disciplinas, as notas dos quatro bimestres, a média final e a situação em cada matéria.*/


int colunaString = 2;
int linhafloat = 0;
int colunafloat = 5;
float media = 0;

Console.WriteLine("Quantas Materias você tem na sua escola :");
int linhas = int.Parse(Console.ReadLine());
Console.Clear();

string[,] matrizMaterias = new string[linhas, colunaString];
float[,] matrizNotas = new float[linhas, 5];

void NotasMaterias(string[,] matrizMaterias, float[,] matrizNotas, int linhas, int colunaFloat)
{
    float soma = 0;
    float media = 0;

    for (int i = 0; i < linhas; i++)
    {
        soma = 0;
        Console.Clear();
        Console.WriteLine($"Digite a suas notas para a seguinte materia: {matrizMaterias[i, 0]}");
        for (int j = 0; j < colunaFloat - 1; j++)
        {
            Console.WriteLine($"nota {j + 1}° Bimestre:");
            matrizNotas[i, j] = float.Parse(Console.ReadLine());
            soma += matrizNotas[i, j];
        }
        CalculaMedia(matrizMaterias,media,soma,colunaFloat,i);
        Console.Clear();
    }
}

void CalculaMedia(string[,] matrizMaterias, float media,float soma, int colunaFloat,int i)
{
    media = soma / 4;
    matrizNotas[i, colunaFloat - 1] = media;

    if (media >= 7)
    {
        matrizMaterias[i, 1] = "Aprovado";
    }
    else if (media >= 4)
    {
        matrizMaterias[i, 1] = "Recuperação";
    }
    else
    {
        matrizMaterias[i, 1] = "Reprovado";
    }
}

void PreencheMaterias(string[,] matrizMaterias, int linhas)
{
    int coluna = 0;

    for (int i = 0; i < linhas; i++)
    {
        Console.WriteLine($"Digite o nome da {i+1}° materia");
        matrizMaterias[i, coluna] = Console.ReadLine();
    }
}

void ImprimeBoletim(string[,] matrizMaterias, float[,] matrizNotas, int linhas, int colunaFloat)
{
    Console.WriteLine(
        $"{"MATERIA",-20} {"N1",8} {"N2",8} {"N3",8} {"N4",8} {"MEDIA",8} {"SITUACAO",-15}"
    );

    Console.WriteLine(new string('-', 85));

    for (int i = 0; i < linhas; i++)
    {
        Console.Write(
            $"{matrizMaterias[i, 0],-20} "
        );

        for (int j = 0; j < colunaFloat; j++)
        {
            Console.Write($"{matrizNotas[i, j],8:F2} ");
        }

        Console.WriteLine($"{matrizMaterias[i, 1],-15}");
    }
}

PreencheMaterias(matrizMaterias, linhas);
NotasMaterias(matrizMaterias, matrizNotas, linhas, colunafloat);
ImprimeBoletim(matrizMaterias, matrizNotas, linhas, colunafloat);
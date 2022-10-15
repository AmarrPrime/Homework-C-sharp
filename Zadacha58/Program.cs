/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int m = matrixA.GetLength(0);
    int n = matrixA.GetLength(1);
    int k = matrixB.GetLength(1);
    int[,] multMatrix = new int[m, k];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            int sum = 0;
            for (int l = 0; l < n; l++)
            {
                sum = matrixA[i, l] * matrixB[l, j] + sum;
            }
            multMatrix[i, j] = sum;
        }
    }
    return multMatrix;
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int k = GetNumber("Введите число k");

int[,] matrixA = InitMatrix(m, n);
int[,] matrixB = InitMatrix(n, k);

Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);

Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);


int[,] result = MultiplyMatrices(matrixA,matrixB);
Console.WriteLine("Результат перемножения матриц: ");
PrintMatrix(result);

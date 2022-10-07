//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



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

double AveragesCalculation(int column, int[,] matrix)
{
    double sum = 0;
    int m = matrix.GetLength(0);
    for (int i = 0; i < m; i++)
    {
        sum = sum + matrix[i, column];
    }
    sum = sum / m;
    return sum;
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine($"Cреднее арифметическое элементов столбцов: ");

for (int column = 0; column < matrix.GetLength(1); column++)
{
    double average = AveragesCalculation(column, matrix);
    average = Math.Round(average, 2);
    Console.Write($"{average} ");
}
/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
using System;


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


void SortingRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int[] row = GetRow(matrix, i);
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = row[j];
        }
    }
}




int[] GetRow(int[,] matrix, int rowIndex)
{
    int[] row = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        row[i] = matrix[rowIndex, i];
    }
    return row;
}



int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
SortingRows(matrix);
Console.WriteLine("Матрица после сортировки:");
PrintMatrix(matrix);

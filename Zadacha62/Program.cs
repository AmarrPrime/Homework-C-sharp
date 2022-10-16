/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, m];

    int number = 1;
    int top = 0;
    int bottom = m - 1;
    int left = 0;
    int right = m - 1;

    while (top <= bottom && left <= right)
    {
        number = Fill(matrix, top, top, left, right, number);
        top++;
        if(number>m*m)
        {
            break;
        }
        number = Fill(matrix, top, bottom, right, right, number);
        right--;
         if(number>m*m)
        {
            break;
        }
        number = Fill(matrix, bottom, bottom, right, left, number);
        bottom--;
         if(number>m*m)
        {
            break;
        }
        number = Fill(matrix, bottom, top, left, left, number);
        left++;
         if(number>m*m)
        {
            break;
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

int Fill(int[,] matrix, int top, int bottom, int left, int right, int currentNumber)
{
    int i = top;
    int incrementI = GetIncrement(top, bottom);

    int incrementJ = GetIncrement(left, right);

    while (i != bottom + incrementI)
    {
        int j = left;
        while (j != right + incrementJ)
        {
            matrix[i, j] = currentNumber;
            currentNumber++;
            j = j + incrementJ;
        }
        i = i + incrementI;
    }
    return currentNumber;
}

int GetIncrement(int left, int right)
{
    if (left > right)
    {
        return -1;
    }
    else
    {
        return 1;
    }
}





int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);


/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить 
с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */



void PrintNumber(int n)
{
    if (n != 1)
    {
        Console.Write($"{n}, ");
        PrintNumber(n-1);
    }
    else
    {
        Console.Write($"{n}.");
    }
}

Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "");
PrintNumber(numberN);






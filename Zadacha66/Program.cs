/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int GetSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + GetSum(m + 1, n);
    }
}


int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");
Console.WriteLine($"Сумма в промежутке между {m} и {n} равна {GetSum(m,n)}.");



//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число B: ");
int power = int.Parse(Console.ReadLine() ?? "");

int temp = 1;

for (int i = 0; i < power; i++)
{
    temp = number * temp;
}
Console.WriteLine($"{temp}");
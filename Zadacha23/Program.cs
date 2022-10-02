//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cubeLimit = int.Parse(Console.ReadLine() ?? "");

for (int start = 1; start <= cubeLimit; start++)
{
    Console.Write($"{Math.Pow(start, 3)}");
    if (start < cubeLimit)
    {
        Console.Write(", ");
    }
}

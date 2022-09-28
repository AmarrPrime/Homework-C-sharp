//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "");

int a = 2;
while (a <= numberN)
{
    Console.Write(a + " ");
    a = a + 2;
}
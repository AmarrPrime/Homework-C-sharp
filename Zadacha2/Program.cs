//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine() ?? "");

if (numberA > numberB)
{ 
    Console.WriteLine("Максимальное число: {0}, минимальное число: {1}", numberA , numberB); 
}
else
{
    Console.WriteLine("Максимальное число: {0}, минимальное число: {1}", numberB, numberA); 
}
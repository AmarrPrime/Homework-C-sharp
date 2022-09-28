//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int numberEntered = int.Parse(Console.ReadLine() ?? "");

int remains = numberEntered % 2;

if (remains == 0)
{
    Console.WriteLine(" число четное ");
}
else
{
    Console.WriteLine(" число нечетное ");
}
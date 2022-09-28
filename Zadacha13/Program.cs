//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число");
string numberString = Console.ReadLine() ?? "";
int number = int.Parse(numberString);

if (number > 99)
{
    Console.WriteLine("Третья цифра числа это " + numberString[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

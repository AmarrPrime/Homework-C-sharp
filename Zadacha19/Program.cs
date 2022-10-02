//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
//int takeFive = int.Parse(Console.ReadLine() ?? "");

string takeFive = Console.ReadLine() ?? "";

if (takeFive[0] == takeFive[4] && takeFive[1] == takeFive[3])
{
    Console.WriteLine("Это число палиндром.");
}
else
{
    Console.WriteLine("Это число не палиндром.");
}





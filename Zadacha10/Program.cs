//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите число");
int numberEntered = int.Parse(Console.ReadLine() ?? "");

if(numberEntered < 1000 && numberEntered > 99)
{
    int temp = numberEntered/10;
    int secondDigit = temp%10;
    Console.WriteLine("Вторая цифра числа это {0}",secondDigit);
}
else
{
    Console.WriteLine("Почти)");
}
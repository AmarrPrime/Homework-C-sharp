//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
string numbersArr = Console.ReadLine() ?? "";
int digitSum = 0;
for (int i = 0; i < numbersArr.Length; i++)
{
    int digit = int.Parse(numbersArr[i].ToString());
    digitSum = digit + digitSum;
}

Console.WriteLine($"Сумма цифр в числе: {digitSum}");
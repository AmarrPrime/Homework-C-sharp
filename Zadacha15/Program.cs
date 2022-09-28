//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine() ?? "");


if(day >= 1 & day <= 5)
{
    Console.WriteLine("Это не выходной день");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("ЭТО НЕ БУГУЛЬМА!");
}

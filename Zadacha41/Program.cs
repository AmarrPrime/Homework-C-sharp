//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел хотите проверить? ");
int numbersEntered = int.Parse(Console.ReadLine() ?? "");
int count = 0;

for (int i = 0; i < numbersEntered; i++)
{
    int temp = int.Parse(Console.ReadLine() ?? "");

    if (temp > 0)
    {
        count++;
    }
}

Console.WriteLine($"Вы ввели {count} положительных чисел.");

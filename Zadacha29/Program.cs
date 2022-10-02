//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите числа через запятую ");

int [] array = new int[8];
string arraytoenter = Console.ReadLine() ?? "";
string[] mass = arraytoenter.Split(",");
for (int i = 0; i < mass.Length; i++)
{
    array[i] = int.Parse(mass[i]);
}

Console.WriteLine("[{0}]", string.Join(", ", array));

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

bool IsEven(int number)
{
    return number % 2 == 0;
}


int[] InitArray(int lange)
{
    int[] arr = new int[lange];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("Введите количество чисел в массиве");
int len = int.Parse(Console.ReadLine() ?? "");

int[] array = InitArray(len);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (IsEven(array[i]))
    {
        count++;
    }

}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Количество четных чисел в массиве: {count}");
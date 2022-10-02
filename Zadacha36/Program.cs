//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] InitArray(int lange)
{
    int[] arr = new int[lange];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-1000,1000);
    }
    return arr;
}

Console.WriteLine("Введите количество чисел в массиве");
int len = int.Parse(Console.ReadLine() ?? "");

int[] array = InitArray(len);

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];
}

Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {sum}");
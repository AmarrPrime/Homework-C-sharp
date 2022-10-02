//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] InitArray(int lange)
{
    double[] arr = new double[lange];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 2000 - 1000; //чтобы не такие маленькие числа были + отрицательные
    }
    return arr;
}

Console.WriteLine("Введите количество чисел в массиве");
int len = int.Parse(Console.ReadLine() ?? "");

double[] array = InitArray(len);

double diff = array.Max() - array.Min();

Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
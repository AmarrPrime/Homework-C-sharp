/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,,] InitMatrix3D(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rand = new Random();

    Dictionary<int, bool> book = new Dictionary<int, bool>();
    int number = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                number = rand.Next(10, 100);
                while (book.ContainsKey(number))
                {
                    number = rand.Next(10, 100);
                }
                matrix[i, j, k] = number;
                book.Add(number, true);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
















int x = GetNumber("Введите число x");
int y = GetNumber("Введите число y");
int z = GetNumber("Введите число z");

if (x * y * z > 90)
{
    Console.WriteLine("Невозможно заполнить массив не повторяющимися двузначными числами. ");
}
else
{
    Console.WriteLine("Матрица:");
    PrintMatrix(InitMatrix3D(x, y, z));
}
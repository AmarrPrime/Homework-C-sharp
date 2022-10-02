//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int x1 = ReadData("Введите координату Х первой точки: ");
int y1 = ReadData("Введите координату y первой точки: ");
int z1 = ReadData("Введите координату z первой точки: ");
int x2 = ReadData("Введите координату x второй точки: ");
int y2 = ReadData("Введите координату Y второй точки: ");
int z2 = ReadData("Введите координату z второй точки: ");

double FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return result;
}

double res = FindLen(x1, y1, z1, x2, y2, z2);
res = Math.Round(res, 3);

Console.WriteLine("Расстояние между точками: " + res.ToString());
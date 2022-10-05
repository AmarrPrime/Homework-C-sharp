//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadCoef(string coefName)
{
    Console.WriteLine($"Введите коеффициент {coefName}");
    double value = double.Parse(Console.ReadLine() ?? "");
    return value;
}

double k1 = ReadCoef("k1");
double b1 = ReadCoef("b1");
double k2 = ReadCoef("k2");
double b2 = ReadCoef("b2");

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпали.");
    }
    else
    {
        Console.WriteLine("Прямые параллельны.");
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * b2 - b1 * k2) / (k1 - k2);
    Console.WriteLine($"Точка пересечения имеет координаты ({x};{y}).");
}

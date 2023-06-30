// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


static double[] FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        return null;
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] { x, y };
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] point = FindIntersectionPoint(b1, k1, b2, k2);
if (point == null)
{
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
}
else
{
    Console.WriteLine($"Точка пересечения прямых: ({point[0]:F1}; {point[1]:F1})");
}
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите  Х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  Х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double Sx = Math.Pow(x2 - x1,2);
double Sy = Math.Pow(y2 - y1,2);
double Sz = Math.Pow(z2 - z1,2);
double Res = Math.Sqrt(Sx + Sy + Sz);

Console.WriteLine($" расстояние между ними в 3D пространстве :{Res:f2}");
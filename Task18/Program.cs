// Задача 17

Console.WriteLine("Введите Четверть");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("X>0 Y>0");
}
else if (x == 2)
{
    Console.WriteLine("X<0 Y>0");
}
else if (x == 3)
{
    Console.WriteLine("X<0 Y<0");
}
else if (x == 4)
{
    Console.WriteLine("X>0 Y<0");
}
else
{
    Console.WriteLine("Невозможно определить");
    }
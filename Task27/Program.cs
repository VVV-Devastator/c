// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string A)
{
    Console.WriteLine(A);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int a)
{
    int count = 0;
    int sum = 0;
    while (a>10)
    {
        count = a % 10;
        sum = sum + count;
        Console.WriteLine(count);
        a = a / 10;       
    }
    sum = sum + a % 10; 
    return sum;

}

int number = ReadInt("Введите целое число до 2147483647");
int summa = SumFrom1ToA(number);
Console.WriteLine($"Сумма чисел равна {summa}");
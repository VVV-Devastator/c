// Задача 24

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i<=a; i++)
    { 
        sum = sum +i;
    }
    return sum;

}

int number = ReadInt();
int summa = SumFrom1ToA(number);
 Console.WriteLine($"сумма от 1 до {number} равна {summa}");
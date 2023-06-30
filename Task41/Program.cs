// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

static int CountPositiveNumbers(int M)
{
    int count = 0; // переменная для хранения количества чисел больше 0

    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
    }

    return count;
}

Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = CountPositiveNumbers(M);
Console.WriteLine("Количество чисел больше 0: " + count);
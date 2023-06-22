// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int ReadInt(string A)
{
    Console.WriteLine(A);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int a, int b)
{
    int sum = a;
    for (int i = 1; i<b; i++)
    { 
        sum = sum * a;
    }
    return sum;

}

int number = ReadInt("Введите целое число");
int number2 = ReadInt("Введите степень числа");
int summa = SumFrom1ToA(number,number2);
 Console.WriteLine($"Натуральная степень {number2} числа  {number} равна {summa}");
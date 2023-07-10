
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalNumbers(m, n); // вызываем функцию для нахождения суммы

if (sum == 0) {
    Console.WriteLine("Введите другие числа, m должно быть меньше n");    
}
else {
    Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", m, n, sum);
}

static int SumNaturalNumbers(int m, int n) {
    if (m > n) {return 0;}
    if (m == n) {
        return m;
    } else { 
        return m + SumNaturalNumbers(m + 1, n);
    }
}

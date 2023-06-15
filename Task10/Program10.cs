// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int numStr1 = Convert.ToInt32(Console.ReadLine());

int secondDigit = (numStr1 / 10) % 10;
Console.WriteLine($"Вторая цифра числа {numStr1}: {secondDigit}");
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите однозначное число от 1 до 7: ");
int numStr1 = Convert.ToInt32(Console.ReadLine());


if (numStr1 > 0 & numStr1 <6)
{
    Console.WriteLine($"Нет, Рабочий день");
}
else if (numStr1 > 5 & numStr1 <8)
{
     Console.WriteLine($"Даааа, день выходной");
}
else 
{Console.WriteLine($"Введите правильное число");}
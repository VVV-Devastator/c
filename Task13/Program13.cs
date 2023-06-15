// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите  число: ");
int numStr1 = Convert.ToInt32(Console.ReadLine());
int numStr2 = numStr1;
while (numStr1 >999) 
{
    numStr1 = numStr1/10;
}
int thirdDigit = numStr1  % 10;
if (numStr1 > 100)
{
    Console.WriteLine($"Третья цифра числа {numStr2}: {thirdDigit}");
}
else
{
     Console.WriteLine($"В числе {numStr2} нет третьей цифры");
}
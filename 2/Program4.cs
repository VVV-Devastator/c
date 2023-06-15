// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 3 числa:");
int numStr1 = Convert.ToInt32(Console.ReadLine());
int numStr2 =  Convert.ToInt32(Console.ReadLine());
int numStr3 =  Convert.ToInt32(Console.ReadLine());
int numStrmax = numStr1;

if (numStrmax < numStr2){
    numStrmax = numStr2;
}

 if (numStrmax < numStr3)
{
    numStrmax = numStr3; 
}
Console.WriteLine(numStrmax); 
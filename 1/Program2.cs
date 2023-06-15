// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

Console.WriteLine("Введите 2 числa:");
int numStr1 = Convert.ToInt32(Console.ReadLine());
int numStr2 =  Convert.ToInt32(Console.ReadLine());

if (numStr1 > numStr2){
   Console.WriteLine("max="+numStr1+ "  min="+numStr2);
}
else if (numStr1 < numStr2)
{
     Console.WriteLine("max="+numStr2+ "  min="+numStr1);  
}

if (numStr1 == numStr2){
   Console.WriteLine("Числа равны");
}
 


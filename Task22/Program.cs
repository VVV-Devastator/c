// Задача 22 вход число N вывод таблица квадратов чисел от 1 до N


Console.WriteLine("Введите  число");
int x = Convert.ToInt32(Console.ReadLine());

for (int i =1 ; i<=x; i++)
{

    Console.WriteLine(Math.Pow(i,2));   
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2


Console.WriteLine("Введите координаты точки в матрице, столбец:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки в матрице, строка:");
int n1 = Convert.ToInt32(Console.ReadLine());
int m = 4;
int n = 4;
int row = 1;
int col = 2;
int[,] array = CreateRandomArray(m, n);
// *****************************************************

if (n1 > n || m1 > m) 
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
else
{
    int value = GetValueFromArray(array, row, col);
    Console.WriteLine("Значение элемента: " + value);
    Console.WriteLine("Массив: ");
    PrintArray(array);
}
// *****************************************************


int[,] CreateRandomArray(int m, int n)
    {
        int[,] array = new int[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] =  random.Next(10,100); // случайное число в диапазоне [-5, 5)
             }
        }

        return array;
    } 


int GetValueFromArray(int[,] array, int row, int col)
    {   
        return array[row, col];
    }


void PrintArray(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

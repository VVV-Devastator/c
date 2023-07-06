
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2


Console.WriteLine("Введите координаты точки в 4х  матрице, столбец (столбцы считаются с 1 до 4):");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки в 4х  матрице, строка (строки считаются с 1 до 4):");
int row = Convert.ToInt32(Console.ReadLine());
int m = 4;
int n = 4;

int[,] array = CreateRandomArray(m, n);
// *****************************************************

if (col-1 >= n || row-1 >= m || col-1 < 0 || row-1 < 0)  
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
else
{
    int value = array[row-1, col-1];
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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

static int FindRowWithMinSum(int[,] arr) {
    int minRowIndex = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++) {
            int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {
                sum += arr[i, j];
            }
        if (sum < minSum) {
                minSum = sum;
                minRowIndex = i;
        }
    }
        return minRowIndex;
}

int[,] CreateRandomArray(int m, int n)
    {
        int[,] array = new int[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] =  random.Next(1,9); 
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


// задаем исходный массив
int[,]  arr = CreateRandomArray(4,4);


//находим строку с наименьшей суммой элементов
int minRowIndex = FindRowWithMinSum(arr);

// выведем номер строки с наименьшей суммой элементов (нумерация с единицы)
Console.WriteLine("Строка с наименьшей суммой элементов: " + (minRowIndex + 1));
// выведем массив
PrintArray(arr);
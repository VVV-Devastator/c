// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int m = 3;
int n = 4;

int[,] array = CreateRandomArray(m,n);

int numRows = array.GetLength(0);
int numCols = array.GetLength(1);



double[] columnAverages = GetColumnAverages(array, numRows, numCols);
Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int j = 0; j < numCols; j++)
    {
        Console.Write(columnAverages[j].ToString("F1") + " ");
    }
Console.WriteLine("");
PrintArray(array); 

static double[] GetColumnAverages(int[,] array, int numRows, int numCols)
    {
        double[] columnAverages = new double[numCols];
        for (int j = 0; j < numCols; j++)
        {
            int sum = 0;
            for (int i = 0; i < numRows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double) sum / numRows;
        }
        return columnAverages;
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

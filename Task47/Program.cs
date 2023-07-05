// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество Строк");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandomArray(m, n);
PrintArray(array);

double[,] CreateRandomArray(int m, int n)
    {
        double[,] array = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = 10 * random.NextDouble() - 5; // случайное число в диапазоне [-5, 5)
                array[i, j] = Math.Round(array[i, j], 1); // округляем до одного знака после запятой
            }
        }

        return array;
    }

void PrintArray(double[,] array)
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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



int[,] arr =CreateRandomArray(3,4);


// пройдемся по каждой строке и отсортируем ее
for (int i = 0; i < arr.GetLength(0); i++) {
    int[] row = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++) {
                row[j] = arr[i, j];
            }
        Array.Sort(row, (x, y) => y.CompareTo(x));
        for (int j = 0; j < arr.GetLength(1); j++) {
                arr[i, j] = row[j];
            }
    }

// выведем итоговый массив
for (int i = 0; i < arr.GetLength(0); i++) {
    for (int j = 0; j < arr.GetLength(1); j++) {
                Console.Write(arr[i, j] + " ");
        }
         Console.WriteLine();
     }
    
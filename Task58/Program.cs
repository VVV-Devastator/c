// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

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


// задаем первую матрицу
int[,] a = CreateRandomArray(2,2);

// задаем вторую матрицу
int[,] b = CreateRandomArray(2,2);

// проверяем, что можно перемножить матрицы
if (a.GetLength(1) != b.GetLength(0)) {
    Console.WriteLine("Невозможно перемножить матрицы");
    return;
}

// создаем результирующую матрицу
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

// перемножаем матрицы
for (int i = 0; i < a.GetLength(0); i++) {
    for (int j = 0; j < b.GetLength(1); j++) {
        int sum = 0;
        sum += a[i, j] * b[i, j];
        c[i, j] = sum;
    }
}

 Console.WriteLine("Первая матрица");
PrintArray(a);
 Console.WriteLine("Вторая матрица");
PrintArray(b);
 Console.WriteLine("Результирующая матрица");
PrintArray(c);
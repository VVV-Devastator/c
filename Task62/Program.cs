
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




int[,] arr = new int[4, 4];
int value = 1;
int n = arr.GetLength(0);
int i = 0, j = 0;
int di = 0, dj = 1;

for (int k = 0; k < n * n; k++) {
    arr[i, j] = value++;
    if (i + di < 0 || i + di >= n || j + dj < 0 || j + dj >= n || arr[i + di, j + dj] != 0) {
        int tmp = di;
        di = dj;
        dj = -tmp;
    }
    i += di;
    j += dj;
}

// выводим полученный массив
for (int x = 0; x < n; x++) {
    for (int y = 0; y < n; y++) {
        Console.Write("{0:00} ", arr[x, y]);
    }
        Console.WriteLine();
    }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Функция для нахождения разницы между максимальным и минимальным элементами массива
static int GetMaxMinDifference(int[] arr) {
    int max = arr[0];
    int min = arr[0];

    // Находим максимальный и минимальный элементы массива
    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] > max) {
                max = arr[i];
        }
        if (arr[i] < min) {
                min = arr[i];
        }
    }

        // Вычисляем разницу между максимальным и минимальным элементами
    int diff = max - min;
    Console.WriteLine("Массив: " + " Мin:"+string.Join(", ", min) + " Мах:"+ string.Join(",", max));
    return diff;
}


static int[] GenerateRandomArray(int length) {
    int[] arr = new int[length];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(-100, 100);
    }

     return arr;
}

int[] arr =GenerateRandomArray(8);
int diff = GetMaxMinDifference(arr);

Console.WriteLine("Массив: " + string.Join(", ", arr));
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    
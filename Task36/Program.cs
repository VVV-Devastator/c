
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] arr = GenerateRandomArray(4);
int sum = SumOddPositionElements(arr);

Console.WriteLine("Массив: " + string.Join(", ", arr));
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    

// Функция для генерации случайного массива заданной длины
static int[] GenerateRandomArray(int length) {
    int[] arr = new int[length];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(-100, 100);
    }

     return arr;
}

    // Функция для подсчета суммы элементов, стоящих на нечетных позициях
static int SumOddPositionElements(int[] arr) {
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) {
        sum += arr[i];
    }
        return sum;
}
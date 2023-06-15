Random rand = new Random(); // создаем объект для генерации случайных чисел
int num = rand.Next(10, 100); // генерируем случайное число от 10 до 99

Console.WriteLine($"Случайное число: {num}");

int maxDigit = num % 10; // инициализируем максимальную цифру числа
int currentDigit = num / 10; // начинаем проверять вторую цифру числа

if (currentDigit > maxDigit)
{
    maxDigit = currentDigit;
}

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
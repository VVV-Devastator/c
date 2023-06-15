

Random rand = new Random(); // создаем объект для генерации случайных чисел
int num = rand.Next(100, 1000); // генерируем случайное трехзначное число
Console.WriteLine($"Случайное число: {num}");
int firstDigit = num / 100; // получаем первую цифру числа
int thirdDigit = num % 10; // получаем третью цифру числа
int newNum = firstDigit * 10 + thirdDigit; // создаем новое число без второй цифры
 Console.WriteLine($"Число без второй цифры: {newNum}");
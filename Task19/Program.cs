// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите целое число из 5 знаков для проверки на палиндром");
int xPalindrome = Convert.ToInt32(Console.ReadLine());

if (xPalindrome < 10000 || xPalindrome >100000 )
{
    Console.WriteLine($"Введите целое число из 5 знаков !!!");   
}
else
{
    int firstDigit = xPalindrome / 10000; // получаем первую цифру числа
    int Summmm = xPalindrome % 10000;
    int SectDigit = Summmm / 1000; // получаем Вторую цифру числа
    Summmm = xPalindrome % 1000;  
    int ThirtDigit = Summmm / 100; // получаем третью цифру числа
    Summmm = Summmm % 100;  
    int FortDigit = Summmm / 10; // получаем четвертую цифру числа
    int FivetDigit = Summmm % 10; // получаем пятую цифру числа
    // Console.WriteLine($"{firstDigit}");   
    //     Console.WriteLine($"{SectDigit}"); 
    //         Console.WriteLine($"{ThirtDigit}"); 
    //             Console.WriteLine($"{FortDigit}"); 
    //                 Console.WriteLine($"{FivetDigit}"); 
    if (firstDigit == FivetDigit && SectDigit == FortDigit )
    {
        Console.WriteLine($"Чимсло {xPalindrome} является палиндромом"); 
        }
    else 
    {
        Console.WriteLine($"Чимсло {xPalindrome} НЕ является палиндромом"); 
    }    


}
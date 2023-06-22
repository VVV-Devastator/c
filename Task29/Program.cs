// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int ReadInt(string A)
{
    Console.WriteLine(A);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] arr1 = new int [8];
for (int i=0; i<8; i++)
{
    arr1[i] = ReadInt($"Введите целое {i+1} число");
}

Console.Write( "Содержимое массива: ");
Console.Write("[{0}]", string.Join(", ", arr1));




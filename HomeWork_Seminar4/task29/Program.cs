// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
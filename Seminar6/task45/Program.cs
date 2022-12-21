// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] array = {52, 43, 59, 73, 35, 74};
int[] arr = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    arr[i] = array[i];
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", arr)}]");
// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int[] GetRandomMassive(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange +1);
    }

    return array;
}

const int SIZE = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 100;

int[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");

for (int i = 0; i < arr.Length; i++)
{
    
    if (i + 1 > i)
    {
        int max = i + 1;
        int min = i;
    }
    else
    {
        int max = i;
        int min = i + 1;
    }
    Console.WriteLine($"{max}, {min}");
}


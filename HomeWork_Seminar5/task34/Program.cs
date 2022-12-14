// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

double[] GetRandomMassive(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 999;

double[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    
    if (arr[i] % 2 == 1)
    {
        count += 1;
    }
}   
Console.WriteLine(count);       

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] GetRandomMassive(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 4;
const int LEFTRANGE = -100;
const int RIGHTRANGE = 100;

int[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");

int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    sum += arr[i];
}
Console.WriteLine(sum);
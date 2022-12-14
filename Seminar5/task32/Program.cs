// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

const int SIZE = 6;
const int LEFTRANGE = -3;
const int RIGHTRANGE = 3;

int[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.Write($"[{string.Join(", ", arr)}]");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
}
Console.WriteLine($" -> [{string.Join( ", ", arr)}]");
int [] GetRandomMassive(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

(int, int) GetSumPosAndNeg(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)

    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }

    return (sumPositive, sumNegative);
}

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
(int sumP, int sumN) = GetSumPosAndNeg(arr);
Console.WriteLine($"Sum of positive numbers is {sumP}, sum of negative numbers is {sumN}");
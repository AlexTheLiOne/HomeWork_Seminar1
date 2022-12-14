// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int size, int leftRange, int rightRange) // Method for creating a massive
{
    int[] array = new int[size]; // Creat a massive with "size" elements, which we got in parametres
    Random rand = new Random(); // Create a variable for random to not create it inside cycle every time

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) // A massive element is positive
        {
            sumPositive += array[i];
        }
        else // A massive element is negative
        {
            sumNegative += array[i];
        }
    }
    return (sumPositive, sumNegative);
}
const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE); //  int sumP;
Console.WriteLine($"[{string.Join(", ", arr)}]");               //  int sumN;
(int sumP, int sumN) = GetSumPositiveAndNegative(arr);   //  (sumP, sumN) = GetPositiveAndNegative(arr);
Console.WriteLine($"Sum of positive numbers is {sumP}, sum of negative numbers is {sumN}");
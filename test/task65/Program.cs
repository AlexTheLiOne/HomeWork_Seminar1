// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Enter a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = n - m + 1;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = m;
    m++;
}
Console.WriteLine(string.Join(", ", array));
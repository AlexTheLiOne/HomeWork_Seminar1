// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = i + 1;
}
Console.WriteLine(string.Join(", ", array));
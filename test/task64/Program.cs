// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int constN = n;
int[] array = new int[n];

for (int i = 0; i < constN; i++)
{
    array[i] = n;
    n--;
}
Console.WriteLine(string.Join(", ", array));
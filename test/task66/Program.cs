// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter a number: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = M; i <= N; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum}");
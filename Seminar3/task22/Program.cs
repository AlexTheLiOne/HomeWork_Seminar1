// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.WriteLine(i * i);
    i++;
}
if (n <= 0)
{
    Console.WriteLine("Enter a number > 0");
}
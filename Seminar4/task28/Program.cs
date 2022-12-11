// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int count = 1;

while (count <= n)
{
    i = i * count;
    count++;
}
Console.WriteLine(i);
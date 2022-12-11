// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = n;

while (n > min)
{
    n = n / 10;
}

Console.WriteLine(n);

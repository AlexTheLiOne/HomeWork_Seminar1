//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int numbOfDigit = 0;

while (n > 0)
{
    n = n / 10;
    numbOfDigit++;
}
Console.WriteLine(numbOfDigit);
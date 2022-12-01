// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Enter a number 100 to 999: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine($"{number2}");
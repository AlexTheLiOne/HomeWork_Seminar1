// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.​
// 645 -> 5​
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int max = 2147483647;

while (number > 999 && number < max)
{
    Console.WriteLine(number % 10);
}
Console.WriteLine($"{number % 10}");
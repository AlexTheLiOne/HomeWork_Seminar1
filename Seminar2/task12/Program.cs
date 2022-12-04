// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("multiple");
}
else
{
    Console.WriteLine($"not a multiple, remainder {numberA % numberB}");
}
//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

Console.Clear();

Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;
if (numberA > numberB) min = numberB; max = numberA;
{
    Console.WriteLine("max = " + max);
}
if (numberB > numberA) max = numberB; min = numberA;
{
    Console.WriteLine("max = " + max);
}
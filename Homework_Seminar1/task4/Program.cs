// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max && numberB > numberC) max = numberB;
else if (numberC > max && numberC > numberB) max = numberC;
{
    Console.WriteLine(max);
}
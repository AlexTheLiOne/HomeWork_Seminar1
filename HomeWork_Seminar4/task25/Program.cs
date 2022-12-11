// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Enter a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int mult = a;

while (i < b)
{
    mult = mult * a;
    i++;
}
Console.WriteLine(mult);
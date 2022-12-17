// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Enter 3 numbers to check if a triangle exists");

Console.WriteLine("Enter a number 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) Console.WriteLine("The triangle exists");

else
{
    Console.WriteLine("The triangle doesn't exist");
}
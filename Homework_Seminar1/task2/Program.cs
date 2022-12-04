//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

Console.Clear();

Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a); // После первого семинара я так и не смог решить эту задачу
Console.WriteLine(b); // но смог после второго только таким способом. Но мне так и 
if (a > b)            // непонятно как ее решать без знака $
{
    Console.WriteLine($"max = {a}, min = {b}");
}
else
{
    Console.WriteLine($"max = {b}, min = {a}");
}

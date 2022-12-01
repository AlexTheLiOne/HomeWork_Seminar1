// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a number of the day: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
if (number < 1 || number > 7)
{
    Console.WriteLine("Doesn't exist");
}
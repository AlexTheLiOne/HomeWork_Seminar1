// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями;
// y = k1 * x + b1, y = k2 * x + b2; (y = ax + c and y = bx + d; x = d - c / a - b) значения b1, k1, b2 и k2 задаются пользователем;
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5);

Console.WriteLine("Enter a number 1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number 2: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number 3: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number 4: ");
double k2 = Convert.ToInt32(Console.ReadLine());



if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Lines are not crossed");
}
else
{
    double s = (b2 - b1) / (k1 - k2);
    double x = k1 * s + b1;
    double y = k2 * s + b2;
    double g = k1 * (s + b1);
    Console.WriteLine($"{x}; {y}");
}





// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Enter an xA: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an yA: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an xB: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an yB: ");
double yB = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(xB - xA,2);
double resY = Math.Pow(yB - yA,2);
double res = Math.Sqrt(resX + resY);
Console.WriteLine($"{res:f2}");
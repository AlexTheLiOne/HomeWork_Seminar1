// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter an xA point: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an yA point: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an zA point: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an xB point: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an yB point: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an zB point: ");
double zB = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow((xB - xA),2);
double resY = Math.Pow((yB - yA),2);
double resZ = Math.Pow((zB - zA),2);
double res = Math.Sqrt(resX + resY + resZ);
Console.WriteLine($"{res:f2}");
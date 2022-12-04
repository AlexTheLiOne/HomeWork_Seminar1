Console.WriteLine("Enter an X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("the first coordinate quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("the second coordinate quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("the third coordinate quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("the forth coordinate quarter");
}
else
{
    Console.WriteLine("Impossible to define the coordinate quarter");
}
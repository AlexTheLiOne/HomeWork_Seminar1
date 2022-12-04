Console.Clear();

Console.WriteLine("Input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

//string answer = Console.ReadLine();
//int number = Convert.ToInt32(answer);

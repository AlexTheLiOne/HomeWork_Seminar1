// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i ++)
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetNumber("Enter a number: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int summa = Sum1toA(number);
    Console.WriteLine($"Number's sum 1 to {number} = {summa}");
}
else
{
    Console.WriteLine($"Impossible to get the number's sum 1 to {number}");
}


int number = new Random().Next(10 , 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;
Console.WriteLine($"first digit = (digit1), second digit = (digit2)");
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else{
    Console.WriteLine(digit2);
}
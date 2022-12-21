// Method to show number binary view

int a = 13;

void BinaryMethod (int number)
{
    if (number <= 0) return;
    BinaryMethod (number / 2);
    Console.Write(number % 2);
}
BinaryMethod(a);
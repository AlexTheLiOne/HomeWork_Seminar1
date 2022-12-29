// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

double[,] GetRandomMatrix(double rowsCount,  double columsCount, double leftRange = 0, double rightRange = 50)
{
    double[,] matr = new double[rowsCount, columsCount];
    Random rand = new Random();
    
    for (double i = 0; i < matr.GetLength(0); i++)
    {
        for (double j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

double GetNumber(string message) // Method to get a number from console
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
    for (double i = 0; i < matr.GetLength(0); i++)
    {
        for (double j = 0; j < matr.GetLength(1); j++) //Как только заканчивается цикл одномерного массива...
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();  // ...строка переносится
    }
}

int rows = GetNumber("Enter a lines amount: ");
int columns = GetNumber("Enter a columns amount: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);


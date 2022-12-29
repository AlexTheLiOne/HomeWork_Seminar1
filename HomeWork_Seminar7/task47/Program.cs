// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(double rowsCount, double columnsCount, double leftRange, double rightRange)
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

double GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
    for (double i = 0; i < matr.GetLength(0); i++)
    {
        for (double j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double rows = GetNumber("Enter a lines amount: ");
double columns = GetNumber("Enter a columns amount: ");
double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
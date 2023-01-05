// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetRandomMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 50)
{
    int[,] matr = new int[rowsCount, columsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Replace(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int tmp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = tmp;
    }
}

int rows = GetNumber("Enter a rows number: ");
int columns = GetNumber("Enter a columns number: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
Replace(matrix);
PrintMatrix(matrix);
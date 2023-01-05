// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 16)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    int x = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = x;
            x++;
        }
    }
    return matrix;
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

int rows = GetNumber("Enter a number: "); //strokes
int columns = GetNumber("Enter a number:"); //
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GetRandomMatrix(int rowsCount,  int columsCount, int leftRange = 0, int rightRange = 50)
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

int Task(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matr[i, j];
            }
        }
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //Как только заканчивается цикл одномерного массива...
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();  // ...строка переносится
    }
}

int[,] matrix = GetRandomMatrix(4, 4, 3, 9);
PrintMatrix(matrix);
int sum = Task(matrix);
Console.WriteLine();
Console.WriteLine(sum);
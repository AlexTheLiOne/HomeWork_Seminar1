// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix(int rowsCount,  int columnsCount, int leftRange = 0, int rightRange = 50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);   // Подскажите как сделать каждый столбик)))
        }
    }
    return matr;
}

double Task(int[,] matr)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0)
            {
            sum += matr[i, j];
            }
        }
    }
    return sum;
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

int rows = GetNumber("Enter rows` amount: ");
int columns = GetNumber("Enter columns` amount: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);
double sum1 = Task(matrix);
double average = sum1 / rows;
Console.WriteLine();
Console.WriteLine(average);


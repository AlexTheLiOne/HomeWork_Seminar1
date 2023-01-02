// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

void Task(int[,] matr)
{
    Console.WriteLine("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (n == matr[i, j])
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("No number");
            }
        }
    }
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

int[,] matrix = GetRandomMatrix(3, 3, 0, 10);
PrintMatrix(matrix);
Task(matrix);

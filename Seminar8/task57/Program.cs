// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] GetRandomMatrix(int rowsCount,  int columsCount, int leftRange = 0, int rightRange = 9)
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

int[] Task(int[,] matr)
{
    int[] result = new int[10];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            result[matr[i, j]]++;
        }
    }
    return result;
}

int rows = GetNumber("Enter a rows number: ");
int columns = GetNumber("Enter a columns number: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
int[] res = Task(matrix);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(i + " occurs " + res[i] + " times");
}


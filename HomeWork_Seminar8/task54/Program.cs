﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void Replace(int[,] matr, int[,] matrixRez)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j + 1 < j)
            {
                matr[i] = j + 1;
            }
        }
    }
}

int rows = GetNumber("Enter a rows number: ");
int columns = GetNumber("Enter a columns number: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
Replace(matrix);
PrintMatrix(matrixRez);
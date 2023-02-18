﻿// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали 
// с индексами (0,0), (1,1) и т.д. 

int[,] array2D = CreateMartixRndInt(4, 3, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int sumElements = SumElements(array2D);
Console.Write($"Сумма элементов массива на главной диагонали = {sumElements}");

int SumElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
       sum += matrix[i, i];
    }
    return sum;
}

int[,] CreateMartixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn= m + n.
// Выведите полученный массив на экран

int[,] array2D = CreateMartixRndInt(3,5);
PrintMatrix(array2D);


int[,] CreateMartixRndInt (int rows, int columns) 
{
    int[,] matrix = new int[rows, columns]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {  
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i,j] = i + j; 
        }
    }
    return matrix; 
}

void PrintMatrix (int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("["); 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4} "); 
        else Console.Write($"{matrix[i,j], 4} "); 
    }
    Console.WriteLine("]");
    }
}
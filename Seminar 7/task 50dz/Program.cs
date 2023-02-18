// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = 5;
int columns = 5;
int min = 0;
int max = 9;

int[,] matrix = CreateMartixRndInt(rows, columns, min, max);
PrintMatrix(matrix);

Console.WriteLine("Введите индекс строки и столбца элемента:");
int rowIndex = Convert.ToInt32(Console.ReadLine());
int columnIndex = Convert.ToInt32(Console.ReadLine());

if (rowIndex >= 0 && rowIndex < rows && columnIndex >= 0 && columnIndex < columns)
{
    Console.WriteLine($"Значение элемента [{rowIndex}, {columnIndex}] это {matrix[rowIndex, columnIndex]}");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
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
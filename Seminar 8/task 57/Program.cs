// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] matrixGenerate = CreateMartixRndInt(4,4,0,10);
PrintMatrix(matrixGenerate);
Console.WriteLine();
int[] allNumberArray = AllNumbersArray(matrixGenerate);
Array.Sort(allNumberArray);
PrintArray(allNumberArray);
FrequencyDictionary(allNumberArray);


void FrequencyDictionary(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        count++;
        else 
        {
            Console.WriteLine($"Число {num} встречается {count}");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count}");
}

int[] AllNumbersArray(int[,] matrix)
{
    int arraySize = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[arraySize];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        Console.Write($"{array[i], 1} ");
        else Console.WriteLine($"{array[i], 1} ");
    }
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


// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 

int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);
Console.WriteLine();
int elementsCount = ElementsCount(array, 10, 99);
Console.WriteLine($"Количество искомых чисел = {elementsCount}");


int ElementsCount(int[] massive, int min, int max) // создание метода в которо
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] >= min && massive[i] <= max)
        count++;
    }
    return count;
}

int[] CreateArrayRndInt (int size, int min, int max) // Метод наделения массива рандомными числами
{
    int[] arr = new int[size]; // создание массива
    Random rnd = new Random(); // создание переменной в которой будут рандомные числа
    for (int i = 0; i < size; i++) // счетчик
    {
        arr[i] = rnd.Next(min, max + 1); // в массиве переменная i принимает на себя рандомное число и считает каждое число по массиву
    }
    return arr; // возвращает числа в массив
}

void PrintArray (int[] arr) // настройки печати метода в котором лежит массив
{
    Console.Write("["); // выводит [ перед действием счетчика
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // условие при котором все элементы массива, кроме последнего
        // выводятся и печатаются с запятой и пробелом
        else Console.Write($"{arr[i]}"); // условие для последнего элемента без запятой и пробела
    }
    Console.Write("]");
}
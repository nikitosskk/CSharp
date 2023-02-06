// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = CreateArrayRndInt(5, 1, 10);
PrintArray(arr);
Console.WriteLine();
int[] newArr = TwoNumbersMultiply(arr);
PrintArray(newArr);


int[] TwoNumbersMultiply(int[] array)
{
    int size = array.Length/2; // Массив четный
    if (array.Length%2 == 1) size+=1; //если длина массива не делится на 2
    int[] newaArray = new int[size];

    for (int i = 0; i < size; i++)  
    {
        newaArray[i] = array[i] * array[array.Length - 1 - i];
    }  

    if (array.Length%2 == 1) newaArray[size-1] = array[array.Length/2];
    
    return newaArray;
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
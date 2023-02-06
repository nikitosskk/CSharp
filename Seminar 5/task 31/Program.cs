// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9,9]. Найдите сумму отрицательных и положительных 
// элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt (int size, int min, int max) // создание возвращаемого метода и описание метода
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

int[] GetSumNegativePositiveElem (int[] arr) // В этом методе будет выводится и положительное и отрицательное значение для массива
{
    int sumNegative = 0; // создание переменной для суммы отрицательных чисел
    int sumPositive = 0; // создание переменной для суммы положительных чисел

    for (int i = 0; i < arr.Length; i++)    
    {
        if(arr[i] < 0) sumNegative += arr[i]; // условие при котором в переменную добаляем значение элемента
        else sumPositive += arr[i]; // 
    }
    return new int[] { sumNegative, sumPositive }; // возвращаем полученные значения массивом
}

int GetSumNegativeElem (int[] arr) // тут без массива
{
    int sum = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPositiveElem (int[] arr) // тут без массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}
int[] array = CreateArrayRndInt (12, -9, 9); //Присвоение массиву значений size, min, max
PrintArray(array); // вывод массива
int[] sumNegativePositiveElem = GetSumNegativePositiveElem(array); //созадем массив, в котором вызываем метод и передаем ему значение
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativePositiveElem[0]}");
Console.WriteLine($"Сумма положительных элементов = {sumNegativePositiveElem[1]}");

int sumNegativeElem = GetSumNegativeElem(array);
int sumPositiveElem = GetSumPositiveElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных цифр = {sumNegativeElem}");
Console.WriteLine($"Сумма положительных цифр = {sumPositiveElem}");

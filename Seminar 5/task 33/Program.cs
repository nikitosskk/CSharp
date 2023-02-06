// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; Array [6, 7, 345, 3] -> Нет
// 3; Array [6, 7, 345, 3] -> Да

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(4, 0, 10); // создание массива и приведение аргументов
bool cheked = CheckArray(num, array); //создание буловой переменной, в которой метод имеет параметры
PrintArray(array);
Console.WriteLine(cheked ? " -> Да" : " -> Нет");

bool CheckArray(int num, int[] arr) // метод проверки числа в массиве
{
    for  (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true; // "если в массиве есть число num то"
    }
    return false;
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
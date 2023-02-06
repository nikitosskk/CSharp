// Напишите программу замена элементов массива: положительные элеиенты
// замените на соответствующие отрицательные и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] invertArry = CreateArrayRndInt(4, -999, 1000); //создание массива в котором генерируются случайные числа
PrintArray(invertArry); // Печать массива
Console.WriteLine(); // Отступ пустой строкой
InvertArray(invertArry); // использование метода для массива
PrintArray(invertArry); // печать массива



void InvertArray(int [] array1) // Создание метода для инверсии чисел
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = -array1[i]; // С помощью умножения на -1
    }
}

int[] CreateArrayRndInt (int size, int min, int max) // 
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
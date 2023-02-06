// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(array);

double maxNumberArray = MaxNumberArray(array);
double minNumberArray = MinNumberArray(array);
double difference = DifferenceNumber(maxNumberArray, minNumberArray);

Console.WriteLine($" -> {difference}");

double DifferenceNumber(double max, double min) // получение разницы и округление вещественного числа
{
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;;
}

double MaxNumberArray(double[] array) // нахождение макс числа в массиве
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumberArray(double[] array) // нахождение мин числа в массиве
{
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double[] CreateArrayRndDouble (int size, int min, int max) // создание массива с рандомными числами
{
    double[] arr = new double[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++) 
    {
        double num = rnd.NextDouble() * (max - min) + min; // Создание рандомных вещественных чисел
        arr[i] = Math.Round(num, 1); // Округление вещественного числа до одного знака 
    }
    return arr; 
}

void PrintArrayDouble (double[] arr) // печать массива
{
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    Console.Write("]");
}
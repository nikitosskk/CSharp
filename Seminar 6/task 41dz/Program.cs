// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
int num = Convert.ToInt32(Console.ReadLine());
int[] numbers = ReadNumbers(num);
int count = CountPositiveNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Чисел больше 0 -> {count}");

    int[] ReadNumbers(int n) 
    {
        int[] numbers = new int[n];
        Console.WriteLine("Введите числа:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numbers;
    }

    int CountPositiveNumbers(int[] numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    }

    void PrintArray (int[] arr) 
    {
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    Console.Write("]");
    }
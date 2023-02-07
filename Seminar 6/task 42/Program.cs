﻿// Напишите программу которая будет преобразовывать
// десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numBinary = NumBinary(num);
Console.WriteLine(numBinary);

int NumBinary(int number)
{
    int numberBin = 0;
    int count = 1;
    while (number > 0)
    {
        numberBin = numberBin + (number % 2 * count);
        number /= 2;
        count *=10; 
    }
    return numberBin;
}

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// string Binary(int num)
// {
//     string res = string.Empty
//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num /= 2;
//     }
//     return res;
// }

// string binary = Binary(number);
// Console.WriteLine($"{number} -> {binary}");

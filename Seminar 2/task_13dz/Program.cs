﻿// // // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // // ​
// // // 645 -> 5
// // // ​
// // // 78 -> третьей цифры нет
// // // ​
// // // 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num;
int i = 0;

if (num > 99) 
{
    while (num != 0)
    {
        num /= 10; //   /= - разделить переменную на значение и ответ присвоить этой же переменной.
        i++;
    }
    while (i > 3)
    {
        res /= 10;
        i--;
    }
    res %= 10;
    Console.WriteLine(res);
}
else 
{ 
    Console.WriteLine("Третьей цифры нет!"); 
}
// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// int number1 = 7;
// int number2 = 23;

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Это число кратно 7 и 23");
}
else
{
    Console.WriteLine("Это число не кратно 7 и 23");
}

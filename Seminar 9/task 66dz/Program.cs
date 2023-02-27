// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number1, number2);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");

int SumNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1;
    }
    int sumNumber = num2 > num1 ? 1 : -1;
    return SumNumbers(num1 + sumNumber, num2) + num1;
}


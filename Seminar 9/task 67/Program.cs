// Напишите программу, которая на вход принимает число и
// будет возвращать сумму его чисел.

Console.WriteLine("Введите  целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number1);
Console.WriteLine($"сумма чисел равна {sumNumber}");

int SumNumber(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumber(num / 10);
}
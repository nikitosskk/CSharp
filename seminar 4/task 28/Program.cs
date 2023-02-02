// Напишите программу, которая на вход принимает число N
// и выдает произведение чисел от 1 до N.
// 4 -> 26
// 5 -> 120

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int factorialNums = FactorialNums(number);
if (number > 0)
{
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNums}");
}
else
Console.WriteLine("Введите натуральное число");


int FactorialNums(int num)
    {
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
else
{
    if(number2 > number3)
    {
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine(number3);
    }
}


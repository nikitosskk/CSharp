// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 456 ->  3
// 78 -> 2
// 98126 -> 5

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int countNums = CountNums(number);
Console.WriteLine($"Количество цифр в числе {number} = {countNums}");

int CountNums(int num)
{
    if(num < 0) num = -num;

    int count = 0;
    while (num > 0)
    // while ((int)Math.Abs(num) > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
    
}
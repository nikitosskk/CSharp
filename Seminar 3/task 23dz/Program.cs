// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125.

Console.WriteLine("Введите число N:");
int x = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int count = 1;
    while (count <= num )
    {
        Console.WriteLine($"{count,5}, {count * count * count,5}");
        count++;   
    }
}
SquareTable(x);

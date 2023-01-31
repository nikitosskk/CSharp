// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число N:");
int x = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int count = 1;
    while (count <= num )
    {
        Console.WriteLine($"{count,5}, {count * count,5}");
        count++;   
    }
    // for (int i=1; i <= num; i++)
    // {
        //Console.WriteLine($"{i} -> {i * i}); 
    // }
}
SquareTable(x);

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке ОТ -N до N. 

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = - number; i <= number; i++)
{
    Console.Write(i+ " ");
}
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число обозначающее день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7) 
{
    Console.WriteLine("Введите число от 1 до 7!");
}
if (num >= 1 && num <=5)
{
    Console.WriteLine("Будни");
}
if (num >= 6 && num <=7)
{
    Console.WriteLine("Выходные");
}
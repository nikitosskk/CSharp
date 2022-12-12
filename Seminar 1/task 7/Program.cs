// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 723 -> 3

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    // Console.WriteLine(number % 10); 
    int mod = number % 10;
    Console.WriteLine(mod); 
}
else
{
    Console.WriteLine("Введено не трехзначное число!");
}
// Напишите программу, которое выводит случайное трехзначное число из отрезка [10 , 99] и удаляет 2 цифру этого числа.

// Например:
// 786 -> 76
// 125 -> 15
// 857 -> 87

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit1 = number / 100;
int digit2 = number % 10;
int digit3 = (digit1 * 10) + digit2;
Console.WriteLine(digit3);
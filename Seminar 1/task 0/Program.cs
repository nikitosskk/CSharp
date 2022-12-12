// Напишите программу, которая на  вход принимает число и выдает его квадрат ( число умноженное само на себя)

// Например:
// -3 -> 9  
// 4 -> 16
// 7 -> 49

Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine())
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

Console.WriteLine(number * number);


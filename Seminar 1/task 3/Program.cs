Console.WriteLine("Введите число 1 - 7:");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7 || number < 1)
{
    Console.WriteLine("Введите число 1 - 7");
}

if (number == 1) Console.WriteLine("Понедельник");
if (number == 2) Console.WriteLine("Вторник");
if (number == 3) Console.WriteLine("Среда");
if (number == 4) Console.WriteLine("Четверг");
if (number == 5) Console.WriteLine("Пятница");
if (number == 6) Console.WriteLine("Субота");
if (number == 7) Console.WriteLine("Воскресенье");

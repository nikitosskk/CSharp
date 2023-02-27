// Напишите програму, которая на вход принимает два числа А и В,
// и возводит число А в целую степень числа В с помощью рекурсии.

Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int degreeNumber = DegreeNumber(number1, number2);
Console.WriteLine($"Степень числа {number1} = {degreeNumber}");

int DegreeNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return number1 * DegreeNumber(num1, num2 -1);
}
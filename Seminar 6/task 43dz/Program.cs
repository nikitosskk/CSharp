// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения b1, k1, b2, k2:");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

if (!LinesAreParallel(k1, k2))
{
    double x = IntersectionX(k1, b1, k2, b2);
    double y = IntersectionY(k1, b1, x);
    Console.WriteLine($"Точка пересечения находится по координатам ({x:0.##}, {y:0.##})");
}
else
{
    Console.WriteLine("Линии не пересекаются.");
}
        

double IntersectionX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double IntersectionY(double k, double b, double x)
{
    return k * x + b;
}

bool LinesAreParallel(double k1, double k2)
{
    return k1 == k2;
}
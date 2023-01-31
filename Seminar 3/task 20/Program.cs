// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// А(3,6); B(2,1); -> 5,09
// A(7, -5); B(1,-1); -> 7,21

Console.WriteLine("Введите координаты точки x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

double Distance(int x, int y, int x1, int y1)
{
    int cat1 = x - x1;
    int cat2 = y - y1;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return result;
}

double distance = Distance(x, y, x1, y1);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x} {y}) B ({x1} {y1} -> {dRound}");




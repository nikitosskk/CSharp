// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// А(3,6,8); B(2,1,-7); -> 15,84
// A(7, -5, 0); B(1,-1,9); -> 11,53

Console.WriteLine("Введите координаты точки x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z:");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2:");
int z1 = Convert.ToInt32(Console.ReadLine());


double Distance(int x, int y, int z, int x1, int y1, int z1)
{
    int cat1 = x - x1;
    int cat2 = y - y1;
    int cat3 = z - z1;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return result;
}

double distance = Distance(x, y, z, x1, y1, z1);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x} {y} {z}) B ({x1} {y1} {z1} -> {dRound}");




// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли сущещствовать треугольник такой длины
// (Теорема о неравенстве треугольника)

Console.WriteLine("Введдите три стороны треугольника");
Console.WriteLine("Введите сторону a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону c: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool triangleCheck = TriangleCheck(sideA, sideB, sideC);
Console.WriteLine(triangleCheck ? "Да" : "Нет");


bool TriangleCheck(int a, int b, int c)
{
    if (a < (b+c) && b < (a+c) && c < (a+b)) return true;
    else return false;
}

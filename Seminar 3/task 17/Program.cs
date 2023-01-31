// Написать программу, которая на вход  принимает координаты точки (X, Y), причем они не должны быть равны нулю, 
// и выдает номер четверти плоскости в которой находится точка.

Console.WriteLine("Введите координату точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0
? $"Указанныен координаты соответствуют четверти -> {quarter}"
: "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
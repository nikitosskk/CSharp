// Напишите программу, которая по заданному номеру четверти, показывает диапозон
// возможных координат точек в этой четверти (x , y).

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string result = RangeCoordinates(quarter);
Console.WriteLine(result);

string RangeCoordinates(string coords)
{
    if (coords == "1") return "x > 0, y > 0";
    if (coords == "2") return "x < 0, y > 0";
    if (coords == "3") return "x < 0, y < 0";
    if (coords == "4") return "x > 0, y < 0";
    return "Введена неккоректная четверть";
} 
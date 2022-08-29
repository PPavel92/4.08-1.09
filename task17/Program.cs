// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точек:");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.Write("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.Write("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.Write("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.Write("Четвертая четверть");
// }
// else
// {
//     Console.Write("Введены не коректные координаты");
// }

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return ("Первая четверть");
    if (xc < 0 && yc > 0) return ("Вторая четверть");
    if (xc < 0 && yc < 0) return ("Третья четверть");
    if (xc > 0 && yc < 0) return ("Четвертая четверть");
    return "Введены не коректные координаты";
}

string result = Quarter(x,y);
Console.WriteLine(result);
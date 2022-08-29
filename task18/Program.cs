// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.Write("Номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

string QuarNumb(int numb)
{
    if (numb == 1) return "Значение переменных : xc > 0 и yc > 0";
    if (numb == 2) return "Значение переменных : xc < 0 и yc > 0";
    if (numb == 3) return "Значение переменных : xc < 0 и yc < 0";
    if (numb == 4) return "Значение переменных : xc > 0 и yc < 0";
    return "Введены не коректные координаты";
}

string result = QuarNumb(number);
Console.WriteLine(result);
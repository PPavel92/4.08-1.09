// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;
if (number == square)
{
    Console.WriteLine($"Число {number} является квадратом {number2}");
}
else
{
    Console.WriteLine($"Число {number} не является квадратом {number2}");
}
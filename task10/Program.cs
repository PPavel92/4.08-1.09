// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число:");
int number0 = Convert.ToInt32(Console.ReadLine());
if (number0 < 1000 && 99 < number0)
{
    int res = number0 / 10 % 10;
    Console.Write($"{res}");
}
else
{
    Console.Write($"Вы ввели не верное число");
}
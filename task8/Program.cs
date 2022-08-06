// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число:");
int number0 = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (c < number0)
{
   int c = c % 2 == 1;
}
else
{
    Console.Write($" {c}");
}
c = c + 1;

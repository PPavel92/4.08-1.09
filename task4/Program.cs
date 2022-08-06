// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите 1 число:");
int number0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number0;
int max1 = number1;
if (max1 > number2)
{
 max1 = number1;
}
else 
{
    max1 = number2;
}
if (max>max1)
{
    max = number0;
}
else
{
    max = max1;
}
Console.Write($"Максимальное число из чисел {number0}; {number1}; {number2} будет число {max}");
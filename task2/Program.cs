// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число:");
int numbers0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numbers1 = Convert.ToInt32(Console.ReadLine());
int max = numbers0;
int min = numbers1;
if (max < min)
{
    max = numbers1;
    min = numbers0;
} 
Console.WriteLine($"Число {max} больше числа {min}");

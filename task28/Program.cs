// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int MultNum(int n)
{
    int m = 1;
    for (int i = 1; i <= n; i++)
    {
        m *= i;
    }
    return m;
}
int result = MultNum(num);
Console.WriteLine($"Произведение чисел от 1 до {num} -> {result}");
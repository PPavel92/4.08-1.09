// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int SumNum(int n)
{
    int count = Convert.ToString(n).Length;
    int str = 0;
    int res = 0;
 for (int i = 0; i < count; i++)
    {
        str = n - n % 10;
        res = res + (n - str);
        n = n / 10;
    }
    return res;
}
int sum = SumNum(num);
Console.Write($"Cумму цифр в числе {num} -> {sum}");
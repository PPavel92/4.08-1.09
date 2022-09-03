// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int ChangeToBin(int a)
{
    int result = 0;
    int mult = 1;
    while (a > 0)
    {
        result += a % 2 * mult;
        a /= 2;
        mult *= 10;
    }
    return result;
}
int res = ChangeToBin(numb);
Console.WriteLine(res);

// через рекурсию//

// int num = 13;
// void DecToBin(int n)
// {
//     if (n == 0) return;
//     DecToBin(n / 2);
//     Console.Write(n % 2);
// }
// DecToBin(num);
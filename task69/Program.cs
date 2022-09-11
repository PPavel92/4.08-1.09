// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите целое положительное число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

// int MultiPlay(int a, int b)  // Первый метод
// {
//     int res = a;
//     if (b == 0) return 1;
//     else
//     {
//         res *= MultiPlay(a, b - 1);
//     }
//     return res;
// }

int MultiPlay(int a, int b)     // Второй метод
{
    if (b == 0) return 1;
    return a * MultiPlay(a, b - 1);
}


int result = MultiPlay(numberA, numberB);
Console.WriteLine(result);
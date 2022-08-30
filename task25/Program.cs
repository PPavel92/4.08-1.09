// Задача 25: Напишите цикл,
//  который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int NaturaDegree(int an, int bn)
{
    int am = 1;
    for (int i = 1; i <= bn; i++) am = am * an; 
    return am;
}
int result = NaturaDegree(a, b);
Console.WriteLine($"Число A {a} степени В {b} -> {result}");






// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число A");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumBetween(int am, int an)
{
  if (am > an) return am;
 if (an==am) return am;
 return am + SumBetween(am+1, an);
}
int result = SumBetween(numberM, numberN);
Console.WriteLine($"Снмма натуральных чисел в промежутке от {numberM} до {numberN} => {result}");
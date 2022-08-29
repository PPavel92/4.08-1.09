// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int CountNumbers(int num)
{
int counter =1;
while (number >= 10)
{
    number = number /10;
    counter++;
}
return counter;
}
int result = CountNumbers(number);
Console.WriteLine($"Колличество цифр в числе {number} = {result}");

// for (; number >=10; number = number /10)
// {
//     counter++;
// }
// Console.WriteLine($"Колличество цифр в числе  = {counter}");
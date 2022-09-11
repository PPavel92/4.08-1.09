// Задача 63: Задайте значене N. Напишите программу, которая выведит
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num}  ");
}

NaturalNumber(number);




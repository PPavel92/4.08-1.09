// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int number)
{
    int fib1 = 0;
    int fib2 = 1;
    Console.Write($"{fib1} {fib2} ");
    for (int i = 2; i < number; i++)
    {
        int nextFib = fib1 + fib2;
        Console.Write($" {nextFib}");
        fib1 = fib2;
        fib2 = nextFib;
    }
}
Fibonacci(n);
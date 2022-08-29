// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int count =1;
while (count <= n)
{
    Console.WriteLine($"|{count} - {Math.Pow(count, 2)} |");  //{count * count}
    count++;

}


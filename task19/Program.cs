// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
bool Palidrom(int n)
{
    int nr = n / 100;
    int h = (nr / 100) + (nr / 10 % 10) + (nr % 10);
    int nr2 = n % 1000;
    int h2 = (nr2 / 100) + (nr2 / 10 % 10) + (nr2 % 10);
    return h == h2;
}
if (number < 100000 && 9999 < number)
{
    bool result = Palidrom(number);
    Console.Write(result ? "Да" : "Нет");
}
else
{
    Console.Write($"Вы ввели не верное число");
}




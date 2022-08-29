// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите число1");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool Del(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
bool result = Del(firstNum, secondNum);
Console.WriteLine(result ? "Да" : "Нет");

// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int firstNum = Convert.ToInt32(Console.ReadLine());

bool Del(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
bool result = Del(firstNum);
// string res = result ? "Да"true : "Нет"false;
Console.WriteLine(result ? "Да" : "Нет");

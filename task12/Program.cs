// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());



void CheckNum (int number1, int number2)
{
    if (number1 % number2 == 0)
    {
        Console.WriteLine($"Число {number1} кратно числу {number2}");
    }
    else
    {
        Console.WriteLine($"Не кратно" + number1 % number2);
    }
}
CheckNum(firstNum,secondNum);
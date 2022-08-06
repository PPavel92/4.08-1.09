// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число от 1 до 7:_");
int number = Convert.ToInt32(Console.ReadLine());
string day = "";
if (number <= 7)
{
    switch (number)
    {
        case 1:
            day = "Понедельник";
            break;
        case 2:
            day = "Вторник";
            break;
        case 3:
            day = "Среда";
            break;
        case 4:
            day = "Четверг";
            break;
        case 5:
            day = "Пятница";
            break;
        case 6:
            day = "Суббота";
            break;
        case 7:
            day = "Воскресенье";
            break;

    }
    Console.WriteLine("День недели:" + day);
}
else
{
    Console.WriteLine("Вы ввели некоректное число");
}
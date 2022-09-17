// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3 n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первой целое положительное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int num2 = Convert.ToInt32(Console.ReadLine());


int MetodAkkerman(int numM, int numN)
{
  if (numM == 0)
    return numN + 1;
  else
    if ((numM != 0) && (numN == 0))
      return MetodAkkerman(numM - 1, 1);
    else
      return MetodAkkerman(numM - 1, MetodAkkerman(numM, numN - 1));
}

int result = MetodAkkerman(num1, num2);
Console.WriteLine(result);
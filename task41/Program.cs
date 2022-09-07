// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите нужное количество чисел: ");
int mNamb = Convert.ToInt32(Console.ReadLine());
int[] arrNumbers = new int[mNamb];

void InputNumbers(int mNamb)
{
for (int i = 0; i < mNamb; i++)
  {
    Console.Write($"{i+1} число: ");
    arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

InputNumbers(mNamb);

int ScoreMoreZero(int[] arrNumbers)
{
  int count = 0;
  for (int i = 0; i < arrNumbers.Length; i++)
  {
    if(arrNumbers[i] > 0 ) count += 1; 
  }
  return count;
}



Console.WriteLine($"Чисел больше 0 -> {ScoreMoreZero(arrNumbers)} ");
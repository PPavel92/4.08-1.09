// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
int SumElementEvanIndex(int[] array)
{
    int sumElem = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sumElem += array[i];
    }
    return sumElem;
}
int[] sumElement = CreateArray(5, -10, 10);
PrintArray(sumElement);
int result = SumElementEvanIndex(sumElement);
Console.WriteLine($"->{result}");

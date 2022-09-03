// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (10 - (-10)) + (10), 2);
    }
    return array;
}
void PrintdoubleArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "|");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
double MaxElementArray(double[] array)
{
    double maxElem = 0;
    double minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem) maxElem = array[i];
        if (array[i] < minElem) minElem = array[i];
    }
    double res = maxElem - minElem;

    return res;
}

double[] arrayOfRealNumbers = CreateArrayRndDouble(5);
PrintdoubleArray(arrayOfRealNumbers);
double result = MaxElementArray(arrayOfRealNumbers);
// Console.WriteLine($" Разница между max и min -->{result}");
Console.WriteLine($" Разница между max и min -->" + result.ToString("00.00"));


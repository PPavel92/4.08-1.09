// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)       ///row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  ///col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void Sum(int[,] matrix)
{
    int min = 0;
    int index = 1;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min = min + matrix[0, i];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];

        }
        Console.WriteLine($"{i + 1} строка {summ}  ");
        if (min > summ)
        {
            min = summ;
            index = i + 1;
        }
    }
    Console.WriteLine($"Строка {index}  наименьшая {min}");

}

int[,] matr = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(matr);
Console.WriteLine();
Sum(matr);
Console.WriteLine();
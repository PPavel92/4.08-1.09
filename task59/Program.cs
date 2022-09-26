// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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

int[,] matr = CreateMatrixRndInt(4, 4, 10, 99);
PrintMatrix(matr);
Console.WriteLine();

int[,] PositionSmallElem(int[,] matrix)
{
    int[,] smallElement = new int[1, 2];
    int temp = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= temp)
            {
                smallElement[0, 0] = i;
                smallElement[0, 1] = j;
                temp = matrix[i, j];
            }
        }
    }
    Console.WriteLine($"Mинимальный элемент: {temp}");
    return smallElement;
}

void DeleteLines(int[,] matrix, int[,] smallElement, int[,] arrayDeleteLines)
{
    int k = 0, l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (smallElement[0, 0] != i && smallElement[0, 1] != j)
            {
                arrayDeleteLines[k, l] = matrix[i, j];
                l++;
            }
        }
        l = 0;
        if (smallElement[0, 0] != i)
        {
            k++;
        }
    }
}
int[,] arrayDeleteLines = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
PositionSmallElem(matr);
int[,] smallElement = PositionSmallElem(matr);
DeleteLines(matr, smallElement, arrayDeleteLines);
PrintMatrix(arrayDeleteLines);
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticHeart20(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arithmeticHeart = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)

        {
            arithmeticHeart += matrix[i, j];
        }
        arithmeticHeart = arithmeticHeart / matrix.GetLength(0);
        arithmeticHeart = Math.Round(arithmeticHeart, 2);
        Console.Write($"{arithmeticHeart}  ");
    }
}



int[,] matri = CreateMatrixRndInt(3, 5, 1, 9);
PrintMatrix(matri);
Console.WriteLine();
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
ArithmeticHeart20(matri);

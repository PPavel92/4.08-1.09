//  Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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
// int[,] SwapRowCol(int[,] matrix) /// Первый метод, работает если квадрат 3х3
// {
//     int row = matrix.GetLength(0);
//     int col = matrix.GetLength(1);
//     int[,] newArr = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             newArr[i, j] = matrix[j, i];
//         }
//     }
//     return newArr;
// }
// int[,] matr = CreateMatrixRndInt(3, 3, 1, 9);
// PrintMatrix(matr);
// Console.WriteLine();
// int[,] newArr = SwapRowCol(matr);
// PrintMatrix(newArr);

void ChangeRowCol(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int copy = matrix[i,j];
            matrix[i,j]= matrix[j,i];
            matrix[j,i]= copy;
        }
    }
}

bool SqMatr(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

 int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
if(SqMatr(matr))
{
    ChangeRowCol(matr);
Console.WriteLine();
PrintMatrix(matr);
}
else
{
    Console.WriteLine($"Невозможно заменить");
}


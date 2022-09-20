// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк 1-й матрицы: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());


int[,] CreateFirstMatrix(int [,] matrixFist,int min, int max)
{
    
    Random rnd = new Random();
    for (int i = 0; i < matrixFist.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFist.GetLength(1); j++)
        {
            matrixFist[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixFist;
}


int[,] CreateSecondMatrix(int [,] matrixSecond,int min, int max)
{
    
    Random rnd = new Random();
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            matrixSecond[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixSecond;
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


void  MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
            
        }


    }
}





int[,] matrFirst = new int [i,j];
int[,] matrSecond = new int [i,j];
int[,] resultMatrix = new int[i,j];
CreateFirstMatrix(matrFirst,1,9);
PrintMatrix(matrFirst);
Console.WriteLine();

CreateSecondMatrix(matrSecond,1,9);
PrintMatrix(matrSecond);
Console.WriteLine();

MultiplyMatrix(matrFirst, matrSecond, resultMatrix);
PrintMatrix(resultMatrix);
//Console.WriteLine(resultMatrix);

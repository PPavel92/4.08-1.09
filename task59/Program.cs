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

// void FindFirstMinElement(int [,] matrix)
// {
//     for (int i = 0; i < PrintMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < PrintMatrix.GetLength(1); j++)
//         {
            
//         }
//     }
// }


int[,] matr = CreateMatrixRndInt(4, 4, -1, 5);   //Не доделал...
//int col =2, row =1;
PrintMatrix(matr);

Console.WriteLine();

PrintMatrix(matr);


int[,] FindPositionSmallElement(int[,] matrix)
{
    int[,] positionSmallElement = new int[1, 2];
  int temp = matrix[0, 0];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] <= temp)
      {
        positionSmallElement[0, 0] = i;
        positionSmallElement[0, 1] = j;
        temp = matrix[i, j];
      }
    }
  }
  Console.WriteLine($"Mинимальный элемент: {temp}");
  return positionSmallElement;
}

void DeleteLines(int[,] matrix, int[,] positionSmallElement)
{
    int[,] arrayWithoutLines = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
  int k = 0, l = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = matrix[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}

FindPositionSmallElement(matr);
int[,] positionSmallElement =FindPositionSmallElement(matr);
DeleteLines(matr, positionSmallElement);

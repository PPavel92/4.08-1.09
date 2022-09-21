// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateMatrixRndInt(int x, int y, int z, int min, int max)
// {
//     int[,,] matrix = new int[x, y, z];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)       ///row
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)  ///col
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
//     return matrix;
// }
void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4}, ");
                else Console.Write($"{matrix[i, j, k],4}");
            }
        }
        Console.WriteLine("]");
    }
}


void Array3D(int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
         
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
    int count = 0;
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = temp[count];
                count++;
            }
        }
    }
}


//int[,,] matr = CreateMatrixRndInt(2, 2, 2, 1, 9);
int[,,] matr = Array3D(2, 2, 2, 1, 9);
PrintMatrix(matr);
//Array3D(matr);
Console.WriteLine();
PrintMatrix(matr);
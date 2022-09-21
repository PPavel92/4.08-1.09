// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int x, int y, int z, int min, int max)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)      
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}
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


void Array3D(int[,,] matrix)     // не доделал вывод построчно.....
{

}

nt[,,] matr = CreateMatrixRndInt(2, 2, 2, 1, 9);

PrintMatrix(matr);
Array3D(matr);
Console.WriteLine();
PrintMatrix(matr);
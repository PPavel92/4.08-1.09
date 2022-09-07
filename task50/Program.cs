﻿// Задача 50. Напишите программу, которая на вход принемает позиции элемента в двухмерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  1,7-> такого элемента в массиве нет.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)       
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  
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

Console.WriteLine("Введите первую позицию");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию ");
int position2 = Convert.ToInt32(Console.ReadLine());

int PositionElement(int[,] matrix, int a )
{
    
 for (int i = 0; i <position1 ; i++)
 {
    a = i;
    Console.WriteLine(a);
 }
 return a;
}

 int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
int result = PositionElement(matr);
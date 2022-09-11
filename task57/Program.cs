// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] ConvertMatrix2ArrayAndSort(int[,] matrix)  //Преоброзовали двумерный массив
{                                         // в однамерный и отсортировали
    int[] result = new int[matrix.Length];    // Length - общее кол-во эл-ов в матрице.
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)  // GetLength - кол-во эл-ов в строке или столбце.
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(result);
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

void CountSimularElems(int[] array)   // Посчитали кол-во одинаковых 
{                                     // элементов в массиве.
    int count = 1;
    int number = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number}-> {count}");
            number = array[i];
            count= 1;
        }
        if(i== array.Length-1)                          //в этом условие мы выводим 
        {                                               // последний элемент в массиве.
            Console.WriteLine($"{number} -> {count}");
        }
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matr);

Console.WriteLine();
int[] arr = ConvertMatrix2ArrayAndSort(matr);
PrintArray(arr);
Console.WriteLine();

CountSimularElems(arr);


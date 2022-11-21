// Задача 53: Задайте двумерный массив.
// Напишите программу которая 
// поменяет местами первую и последнюю строку массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


int rows = 4;
int cols = 4;
int[,] matrixArray = CreateMatrixRndInt(rows, cols, 1, 9);
PrintMatrix(matrixArray);
Sort(matrixArray, rows, cols);
Console.WriteLine();
PrintMatrix(matrixArray);
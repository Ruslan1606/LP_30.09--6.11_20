// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
  
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            int sum = 0;
            for (int k = 0; k < result.GetLength(0); k++) {
                sum += firstMatrix[i,k] * secondMatrix[k,j];         
            }
            result[i,j] = sum;
        }
    }
    return result;
}


int rows = 2;
int cols = 2;
int[,] firstMatrix = CreateMatrixRndInt(rows, cols, 0, 100);
int[,] secondMatrix = CreateMatrixRndInt(rows, cols, 0, 100);

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
var result = MatrixMultiply(firstMatrix, secondMatrix);
PrintMatrix(result);
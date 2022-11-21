// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

void Sort(int[,] matrixArray, int rows, int cols) {
  for (int i = 0; i < rows; i++) {
    for (int k = 0; k < cols; k++)
    for (int j = 0; j < cols - 1; j++){
        if (matrixArray[i,j] < matrixArray[i,j + 1])  {       
          int temp = 0;
          temp = matrixArray[i,j];
          matrixArray[i,j] = matrixArray[i,j + 1];
          matrixArray[i,j + 1] = temp;
        }
    }
  }
}

int rows = 4;
int cols = 4;
int[,] matrixArray = CreateMatrixRndInt(rows, cols, 1, 10);
PrintMatrix(matrixArray);
Sort(matrixArray, rows, cols);
Console.WriteLine();
PrintMatrix(matrixArray);
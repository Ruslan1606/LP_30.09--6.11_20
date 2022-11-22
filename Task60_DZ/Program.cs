// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
  
  int[,,] CreateMatrixRndInt(int rows, int columns, int height, int min, int max)
{
    var matrix = new int[rows, columns, height];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                int value = rnd.Next(min, max + 1);
                while (HasValue(matrix, value)) {
                    value = rnd.Next(min, max + 1);
                }
                matrix[i, j, k] = value;
            }
        }
    }
    return matrix;
}

bool HasValue(int[,,] matrix, int value) {
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                if (matrix[i, j, k] == value)
                    return true;
            }
        }
    } 
    return false;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


int rows = 2;
int cols = 2;
int height = 2;
int[,,] firstMatrix = CreateMatrixRndInt(rows, cols, height, 10, 99);

PrintMatrix(firstMatrix);

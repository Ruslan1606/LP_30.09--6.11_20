// Задача 49: Задайте двумерный массив. Надите элементы,
// у которых оба индекса четные, и замените эти элементы на их квадраты

// например        новый массив
// 1 4 7 2         1 4 49 2
// 5 9 2 3         5 81 2 9
// 8 4 2 4         64 4 4 4


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

void ChengeMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array2D[i, j] *= array2D[i, j];
            }
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2}, ");
            else Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.WriteLine();

ChengeMatrix(array2D);
PrintMatrix(array2D);
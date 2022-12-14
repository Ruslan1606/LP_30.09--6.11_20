// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

double[] ProcessArray(int[,] array2D)
{
    double[] column;
    column = new double[array2D.GetLength(1)];


    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        int sum;
        sum = 0;

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i, j];
        }
        double result = (double)sum / array2D.GetLength(0);
        column[j] = result;
    }

    return column;
}

int[,] MidColumnMatrix(int[,] array2D)
{
    int sum;
    double[] column;
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i, j];
        }
        double result = sum / array2D.GetLength(0);
        column = new double[array2D.GetLength(1)];
        column[j] = result;
    }
    return array2D;
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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

var result = ProcessArray(array2D);
MidColumnMatrix(array2D);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"[{i}] = {result[i]} ");
}
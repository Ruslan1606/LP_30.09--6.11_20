﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SumMinRow(int[,] array2d)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        minRow += array2d[0, i];
    }
    for (int i = 0; i < array2d.GetLength(0); i++)
    {

        for (int j = 0; j < array2d.GetLength(1); j++) sumRow += array2d[i, j];
        if (sumRow <= minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"{minSumRow + 1} строка с минимальным значением");
}


int rows = 4;
int cols = 4;
int[,] matrixArray = CreateMatrixRndInt(rows, cols, 1, 10);
PrintMatrix(matrixArray);
SumMinRow(matrixArray);

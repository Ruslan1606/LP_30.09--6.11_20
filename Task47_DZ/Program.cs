// Задача 47. Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] twodimArray = new double [m , n];
Random rnd = new Random ();

void PrintArray (double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[ i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}

FillArray(twodimArray);
Console.WriteLine();
PrintArray(twodimArray);
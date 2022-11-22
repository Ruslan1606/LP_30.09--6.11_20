// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
  
int[,] CreateArray() {
    int[,] result = new int[4,4];
    int col = 0;
    int row = 0;
    int bound = 1;
    int value = 1;
    int delta = 1;

    while (value <= result.GetLength(0) * result.GetLength(1) - 1) 
    {
        while (col < result.GetLength(1) - bound) 
        {
            result[row,col] = value;
            col += delta;
            value++;
        }
        while (row < result.GetLength(0) - bound)
        {
            result[row,col] = value;
            row += delta;
            value++;
        }
        delta = delta * -1;
        while (col > bound - 1) 
        {
            result[row,col] = value;
            col += delta;
            value++;
        }        
        while (row > bound)
        {
            result[row,col] = value;
            row += delta;
            value++;
        }
        bound++;
        delta = delta * -1;        
    }
    result[row,col] = value;
    return result;
}

void PrintArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (array[i,j] < 10) 
            {
                Console.Write($"0{array[i,j]} ");
            } 
            else 
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

var array = CreateArray();
PrintArray(array);

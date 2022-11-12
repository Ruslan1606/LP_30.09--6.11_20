// Задача 50. Напишите программу, которая на 
// вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента в строке: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[3, 4];





void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

 if (line < numbers.GetLength(0) && column < numbers.GetLength(1))
    Console.WriteLine(numbers[line, column]);
else Console.WriteLine($"{line}{column} -> такого числа в массиве нет");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

FillArray(numbers);
PrintArray(numbers);
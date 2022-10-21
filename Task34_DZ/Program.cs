// Задача 34: Задайте массив 
// заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int[] CreateArrayRndInt(int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}

int size = 10;
int[] array = CreateArrayRndInt(size, 100, 998);
int count = 0;

for (int i = 0; i < size; i++)
{
    int a = array[i];
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

PrintArray(array);
Console.Write($"{count}");
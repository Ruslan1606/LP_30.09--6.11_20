// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов и 
// 2.выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 20);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int[] myArr = FillArray(8);
PrintArray(myArr);

//Как сделать в скобках и через запятую не знаю!
//ПОДСКАЖИТЕ.
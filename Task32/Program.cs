// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArrayRndInt( int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ChangeArrayElem(int[] array)            //Метод инверсии
{                                            //
    for (int i = 0; i < array.Length; i++)   //
    {                                        //   
        array[i] = -array[i];                //  
    }                                        //
}                                            //Метод инверсии

int[] arr = CreateArrayRndInt(12, -30, 30);
PrintArray (arr);
ChangeArrayElem(arr);
PrintArray(arr);
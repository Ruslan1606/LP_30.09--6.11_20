//   Задача 64: Задайте значение N. Напишите программу, 
//   которая выведет все натуральные числа в промежутке от N до 1. 
//   Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumber(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        PrintNumber(number - 1);
    }
    else
    {
        Console.Write($"{number}");
    }
}

Console.WriteLine("Введите число:");
string key = Console.ReadLine();
int number = Int32.Parse(key);
PrintNumber(number);

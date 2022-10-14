// Задача 22. Напишите программу, которая
// 1. принимает на вход число(N) и 
// 2. выдает таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите  число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count =1;

// while (count<= num)
// {
//     Console.WriteLine($"{count} => {count*count}");
//     count++;
// }


// Другой вариант:

void SquareTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица квадратов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,4}|{Math.Pow(index, 2),4}|");
        index++;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareTable(number);

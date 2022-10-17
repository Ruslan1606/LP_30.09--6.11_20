// Задача 27: Напишите программу, которая
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");


int SumNumbers(int num)
{
    int advance = 0;
    int result = 0;
    for (int i = 0; i < number; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}
// Задача 11. Напишите программу, которая
// 1. выводит случайное трехзначное число и
// 2. удаляет вторую цифру этого числа.

// 456->46
// 782->72
// 918->98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапозона 100 - 999 => {number}");

int SecondDigit (int num)
{
    int firstDigit = num / 100;   // 456 / 100 = 4
    int thirdDigit = num % 10;    // 456 % 10 = 6

    return firstDigit * 10 + thirdDigit;
}
int result = SecondDigit(number);
Console.WriteLine($"Без второй цифры числа = {result}");

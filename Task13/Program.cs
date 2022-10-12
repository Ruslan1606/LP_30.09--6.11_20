// Задача 13: Напишите программу, которая
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
 {
    Console.WriteLine("Tретьей цифры нет");
 }
else
{
while (number >= 1000)
{
    number = number / 10;
}

if (number < 1000)
 { 
    int thirdDigit = number % 100;
    int result = thirdDigit % 10;
    Console.WriteLine($"Третья цифра числа = {result}");
 }
 }



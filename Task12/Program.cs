﻿// Задача 12. Напишите программу, которая будет
// 1. принимать на вход два числа и
// 2. выводить, является ли второе число кратным первому.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(10, 100);


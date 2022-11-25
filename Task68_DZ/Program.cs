﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}

Console.WriteLine("Введите число M:");
string keyM = Console.ReadLine();
int numberM = Int32.Parse(keyM);
Console.WriteLine("Введите число N:");
string keyN = Console.ReadLine();
int numberN = Int32.Parse(keyN);
var result = Akkerman(numberM, numberN);

Console.WriteLine($"M = {numberM}; N = {numberN} -> A(m,n) = {result}");

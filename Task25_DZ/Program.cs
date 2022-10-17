// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и
// 2.возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (A == 0)
{
  result = 0;
}
else if(B == 0)
{
  result = 1;
}
else // A != 0 && B != 0
{
  result = A;
  for (int i = 0; i < B -1; i++)
  {
    result = result * A;
  }
}
Console.WriteLine($"{A} в степени {B} = {result}");


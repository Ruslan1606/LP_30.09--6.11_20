// Задача 23 Напишите программу, которая 
// 1. принимает на вход число (N) и
// 2.выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count =1;

while (count<= num)
{
    Console.WriteLine($"{count} => {count*count*count}");
    count++;
}
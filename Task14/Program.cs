// Задача 14. Напишите программу, которая
// 1. принимает на вход число и
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> Нет
// 46 -> Нет
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool CheckingNumber(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

bool result = CheckingNumber(num);
if (result)
{
    Console.Write("да");
}
else{Console.Write("нет");}
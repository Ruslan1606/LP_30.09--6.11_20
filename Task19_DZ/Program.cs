// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и проверяет,
// 2. является ли оно палиндромом.
// Выполнить с помощью числовых операций
//  (целочисленное деление, остаток от деления).

// 14212->нет

// 12821->да

// 23432->да



// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");



//  Вариант целочисленным делением

Console.WriteLine("Введите число! ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=10000 && number <=99999)
{
    if (number / 10000 == number % 10 && (number % 100) / 10 == (number % 1000) / 100)
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - Не является пятизначным числом");
}

// НЕ МОГУ ПОНЯТЬ ПОЧЕМУ НЕ ПРОХОДИТ!!!
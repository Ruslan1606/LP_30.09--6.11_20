// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и проверяет,
// 2. является ли оно палиндромом.
// Выполнить с помощью числовых операций
//  (целочисленное деление, остаток от деления).

// 14212->нет

// 12821->да

// 23432->да

// using System;
// class HelloWorld {
//   static bool isPal(int n)
//   {
//       int r=0,nn=n;
//       while (n>0)
//       {
//           r=r*10+n%10;
//           n=n/10;
//       }
//       return r==nn;
//   }
//   static void Main() {
//     int n;  
//     Console.Write("n=");
//     n=Convert.ToInt32(Console.ReadLine());
//     if (isPal(n))
//        Console.WriteLine("Палиндром");
//     else   
//        Console.WriteLine("Не палиндром");
//   }
// }


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
 int num = Convert.ToInt32(Console.ReadLine());
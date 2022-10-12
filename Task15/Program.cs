// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
switch (number1)
{
    case 1:
        Console.WriteLine("Нет, это Понедельник!");
        break;
    case 2:
        Console.WriteLine("Нет, это Вторник!");
        break;
    case 3:
        Console.WriteLine("Нет, это Среда!");
        break;
    case 4:
        Console.WriteLine("Нет, это Четверг");
        break;
    case 5:
        Console.WriteLine("Нет, это Пятница!");
        break;
    case 6:
        Console.WriteLine("Да, Суббота это выходной!");
        break;
    case 7:
        Console.WriteLine("Да, Воскресенье это выходной!");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}

// Задача 18.напишите программу, которая
// 1.по заданному номеру четверти,
// показывает диапозон возможных координат
//  точек в зтой четверти (X и Y).


Console.WriteLine("Введите номер четверти: ");
string num = Console.ReadLine();


string result = Range(num);
Console.WriteLine(result);

string Range(string number)
{
    if (number == "1") return "x > 0 и y > 0";
    if (number == "2") return "x < 0 и y > 0";
    if (number == "3") return "x < 0 и y < 0";
    if (number == "4") return "x > 0 и y < 0";
    return "Ошибка ввода. ";

}


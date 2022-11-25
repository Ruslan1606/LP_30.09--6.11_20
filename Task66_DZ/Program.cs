// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int startNum, int endNum)
{
    int result = 0;
    for (int i = startNum; i <= endNum; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine("Введите число M:");
string keyM = Console.ReadLine();
int numberM = Int32.Parse(keyM);
Console.WriteLine("Введите число N:");
string keyN = Console.ReadLine();
int numberN = Int32.Parse(keyN);
var result = 0;
if (numberM < numberN)
{
    result = SumNumbers(numberM, numberN);
}
else
{
    result = SumNumbers(numberN, numberM);
}

Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");

// Задача 28: Напишите программу, которая
// 1.принимает на вход число N и 
// 2.выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
// Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial} ");

int Factorial(int num)
{

    int fact = 1;
    int i;
    for (i = 1; i <= number; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Переполнение типа");
            break;
        }

    }
    Console.WriteLine($"Факториал числа {i -1} = {fact}");
    return fact;
}


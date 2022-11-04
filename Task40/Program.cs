// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2);
}

bool triangle = Triangle(number1, number2, number3);
if (triangle) Console.WriteLine("Треугольник со сторонами такой длины может существовать");
else Console.WriteLine("Треугольник со сторонами такой длины не может существовать");
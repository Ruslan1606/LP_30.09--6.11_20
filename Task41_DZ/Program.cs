// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Пример
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел:");
string num;
num = Console.ReadLine();
int number;
number = Convert.ToInt32(num);

int[] numbers = new int[number];
int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
  num = Console.ReadLine();
  number = Convert.ToInt32(num);
  numbers[i] = number;
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
    	count++;
    }
}
Console.WriteLine($"Чисел больше > 0 = {count}");
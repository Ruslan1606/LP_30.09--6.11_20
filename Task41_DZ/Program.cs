// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Пример
// 0, 7, 8, -2, -2 -> 2          Как вводить в строку через запятую не объясняли!!!
// -1, -7, 567, 89, 223-> 3     почему то объяснили на следующем семинаре 


Console.WriteLine("Введите количество чисел:");
string num;                           // Console.ReadLine().Split(",").Select(int.Parse);
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
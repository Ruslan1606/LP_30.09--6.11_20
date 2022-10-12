// Задача 17. Напишите программу, которая
// 1. принимает на вход координаты точки (X и Y), причем X =/ 0 и Y =/ 0 и
// 2. выдает номер четверти плоскости, в коорой находится эта точка.

System.Console.WriteLine("Введите координаты точки");
System.Console. Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console. Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter( x, y);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти = {quarter}"
                            : "Введены не корректные координаты";
System.Console.WriteLine(result);

int Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc < 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;

}

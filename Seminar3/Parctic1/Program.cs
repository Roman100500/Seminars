// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.
int Quad (int x, int y)
{
    int quart = 0;
    if(x > 0 && y > 0)
        quart = 1;
    if(x < 0 && y > 0)
        quart = 2;
    if(x < 0 && y < 0)
        quart = 3; 
    if(x > 0 && y < 0)
        quart = 4;
    return quart;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
int z = Quad(x, y);
Console.WriteLine("Number quarter: " + z);
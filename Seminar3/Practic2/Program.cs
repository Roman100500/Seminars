// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Two_d (int x1, int y1, int x2, int y2)
{
    double lenght;
    lenght = Math.Round(Math.Sqrt(Math.Pow((x2 -x1), 2) + Math.Pow((y2- y1), 2)), 3);
    return lenght;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Two_d(x1, y1, x2, y2);
Console.WriteLine("Lenght = " + res);
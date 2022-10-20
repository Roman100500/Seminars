// Задача 3.Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void Square (int x)
{
    int i = 1;
    while (i <= x)
    {
        Console.Write(Math.Pow(i, 2) +  " ");
        i++;
    }
}

Console.Write("Input a natural number: ");
int x = Convert.ToInt32(Console.ReadLine());
Square(x);
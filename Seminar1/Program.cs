// Д/З 1.
/*
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
*/
/*
// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while (current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/
/*
// Задача 3.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 31625 % 10 = 5
// 31625 % 100 = 25
// 31625 % 1000 = 625
// 31625 % 10000 = 1625
// 31625 % 100000 = 31625

// 31625 / 10 = 3162
// 31625 / 100 = 316
// 31625 / 1000 = 31
// 31625 / 10000 = 3

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Lust digit of {num} is {result}");
*/


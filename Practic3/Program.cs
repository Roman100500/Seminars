// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Quad(int n1, int n2)

{
    if (n1 == n2 * n2 || n2 == n1 * n1)
        return true;
    else
        return false;
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = Quad(a, b);
Console.WriteLine(result);
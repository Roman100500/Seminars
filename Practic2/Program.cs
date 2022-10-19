// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

bool Krat(int n1, int n2)

{
    if (n1 % n2 == 0)
        return true;
    else
        return false;
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = Krat(a, b);
Console.WriteLine(result);
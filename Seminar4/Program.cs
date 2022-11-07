// 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*

int FindSum(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++)
    {
        sum +=current;
    }
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers between 1 and {a} is {FindSum(a)}");

*/

// 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*

int Numbers(int number)
{
    int i = 0;
    while (number != 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Quantity is {Numbers(a)}");

*/

// 3. Написать программу, которая определит произведение чисел от 1 до N

int FindMulti(int number)
{
    int multi = 1;

    for (int current = 1; current <= number; current++)
        multi *=current;
    return multi;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Multi of numbers between 1 and {a} is {FindMulti(a)}");




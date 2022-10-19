// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


int MaxNumber(int number)
{
    int ed = number % 10;
    int des = number / 10;
    if (ed > des)
        return ed;
    else
        return des;
}

int num = new Random().Next(10, 100);
int result = MaxNumber(num);
Console.WriteLine(result + " наибольшая цифра числа " + num);

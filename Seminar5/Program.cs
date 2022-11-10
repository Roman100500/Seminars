                                                        // Зал № 2.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);

// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.

/*

int FindNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

ShowArray(myArray);
int negativeSum = FindNegativeSum(myArray);
Console.WriteLine($"Sum of negative elements is: " + negativeSum);

*/

// Задача 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*

bool Array2(int[] array, int a)
{
    bool s = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
            s = true;
    }
    return s;
}

Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
bool m = Array2(myArray, a);
ShowArray(myArray);
Console.WriteLine(m);

*/

// Задача 3. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*

int Array3 (int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] <= b && array[i] >= a)
            count++;
    return count;
}
Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowArray(myArray);
int l = Array3(myArray, a, b);
Console.WriteLine($"Количество эл-ов массива, значения которых лежат в отрезке [{a}, {b }] = {l}");

*/

// Задача 4. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*

int[] Array4(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
    return array;
}
ShowArray(myArray);
Array4(myArray);
ShowArray(myArray);

*/


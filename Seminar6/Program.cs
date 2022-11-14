
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

/* 
void ShowNum(int[] num)
{
    num[0] += 5;
    Console.WriteLine(num[0]);
}

int[] a = {0, 6, 2};
ShowNum(a);
Console.WriteLine(a[0]);

*/

// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/* 

void ReserveArray(int[] array)
{
    for (int i = 0, j = array.Length -1 ; i < j; i++, j--)
    {
        int temp = array [i];
        array[i] = array [j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);

ShowArray(myArray);
ReserveArray(myArray);
ShowArray(myArray);

*/

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/* 

bool Task2(int a, int b, int c)
{
    bool s = false;
    if (a + b > c && b + c > a && c + a > b)
        s = true;
    return s;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool n = Task2(a, b, c);
Console.WriteLine(n);

*/


// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/* 

int[] Task3(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++)
        array[i] += array[i - 1] + array[i - 2];
    return array;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] myArray = Task3(a, b, l);
ShowArray(myArray);

*/

// Задача 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);

int[] Copy (int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}
ShowArray(myArray);
ShowArray(Copy(myArray));


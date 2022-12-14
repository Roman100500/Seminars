
int[,] CreateRandom2dArray(int rows, int columns, int minvalue, int maxvalue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами n и m строки массива.

/* 

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0
    && row1 < array.GetLength(0)
    && row2 >= 0
    && row2 < array.GetLength(0)
    && row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Console.WriteLine("Incorrect rows  for changing!");
}

Console.Write("Input a number of first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of second row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);

*/

// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/* 

void Replacement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

if (myArray.GetLength(0) != myArray.GetLength(1))
    Console.WriteLine("Replacement impossible!");
else
{
    Console.WriteLine();
    Replacement(myArray);
    Show2dArray(myArray);
}

*/

// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.



int[,] DeleteRowAndColumn(int[,] array)
{
    int min = array[0, 0];
    int x, y;
    x = y = 0;
    int[,] arr1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }

    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
    {
        if (i != x)
            for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
            {
                if (j != y)
                {
                    arr1[k, l] = array[i, j];
                }
                else
                    l--;
            }
        else
            k--;
    }
    return arr1;
}
Console.WriteLine();
int[,] myArray2 = DeleteRowAndColumn(myArray);
Show2dArray(myArray2);


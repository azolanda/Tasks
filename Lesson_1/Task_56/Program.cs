/*  Задача 56.  Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] RowSum(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        resultArray[i] = sum;
    }

    return resultArray;
}

int MaxRow(int[] array)
{
    int minIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[minIndex] > array[i])
        {
            minIndex = i;
        }
    }

    return minIndex;
}

int[,] newArray = Create2DArray(5, 4);
Print2DArray(newArray);
Console.WriteLine();

int[] sumArray = RowSum(newArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {MaxRow(sumArray) + 1}");
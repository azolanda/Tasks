/*  Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] ColumnsAverageArithmetic(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        sum = Math.Round(sum / array.GetLength(0), 1);
        result[i] = sum;
    }

    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]};  ");
    }
    Console.WriteLine();
}

int[,] newArray = Create2DArray(3, 4);
Print2DArray(newArray);

double[] columnsAverageArithmetic = ColumnsAverageArithmetic(newArray);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(columnsAverageArithmetic);
﻿/*  Задача 47. Задайте двумерный массив размером m×n, 
    заполненный случайными вещественными числами.
    m = 3, n = 4.

    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

double[,] Create2DArray(int m, int n, double minRandom, double maxRandom)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * (maxRandom - minRandom) + minRandom, 1);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }

}

double[,] newArray = Create2DArray(3, 4, -9.9, 9.9);
PrintArray(newArray);
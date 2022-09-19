/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/

string[,] CreateSpiralArray(int m, int n)
{
    string[,] array = new string[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        string element = $"{0}";

        for (int j = 1; j <= array.GetLength(1); j++)
        {
            if (i == 0)
            {
                array[i, j - 1] = element + j;
            }

            else if (j == array.GetLength(1))
            {
                for (int k = 1; k < array.GetLength(0); k++)
                {
                    array[k, j - 1] = element + $"{j + k}";
                }

            }

            else if (i == 3 && j < 4)
            {
                if (j == 1)
                {
                    array[i, j - 1] = "10";
                }
                else
                {
                    array[i, j - 1] = element + $"{10 - j + 1}";
                }
            }

            else
            {
                element = $"{1}";
                array[1, j - 1] = element + $"{j + 1}";
                array[2, 0] = element + $"{j - 2}";
                array[2, j] = element + $"{i - j + 5}";
            }
        }
    }

    return array;
}

void Print2DArray(string[,] array)
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

string[,] array2D = CreateSpiralArray(4, 4);
Print2DArray(array2D);
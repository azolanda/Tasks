/*  Задача 54. Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
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

int[,] RowArraySort(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);

    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength - 1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < columnsLength; k++)
            {
                if (array[i, k] > array[i, minPosition])
                {
                    minPosition = k;
                }
            }

            int temp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temp;
        }
    }

    return array;
}

int[,] newArray = Create2DArray(3, 4);
Print2DArray(newArray);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Print2DArray(RowArraySort(newArray));
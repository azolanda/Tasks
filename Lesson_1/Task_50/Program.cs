/*  Задача 50. Напишите программу, которая на вход принимает число 
    и ищет в двумерном массиве, и возвращает индексы этого элемента 
    или же указание, что такого элемента нет.
    
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    7 -> 0 , 2
    5 -> 1 , 0
    18 -> нет такого элемента
*/

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[]? FindNumInArray(int[,] array, int num)
{
    int[] indexArray = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                indexArray[0] = i;
                indexArray[1] = j;
                return indexArray;
            }
        }
    }

    return null;
}

int[,] newArray = Create2DArray(4, 5);
PrintArray(newArray);

Console.WriteLine("Введите натуральное число от 1 до 99:");
int num = int.Parse(Console.ReadLine());

var indexes = FindNumInArray(newArray, num);

if (indexes == null)
{
    Console.WriteLine("нет такого элемента");
}
else
{
    Console.WriteLine($"Индексы: {indexes[0]}, {indexes[1]}");
}
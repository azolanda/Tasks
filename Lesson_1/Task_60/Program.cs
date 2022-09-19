/*  Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

bool isUniq(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num)
                {
                    return false;
                }
            }
        }
    }

    return true;
}

int[,,] Create3DArray(int m, int n, int l, int firstNum, int lastNum)
{
    int[,,] array = new int[m, n, l];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int rand = 0;

                while (!isUniq(array, rand))
                {
                    rand = random.Next(firstNum, lastNum);
                }

                array[i, j, k] = rand;
            }
        }
    }

    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = Create3DArray(2, 2, 2, 10, 100);
Print3DArray(array3D);

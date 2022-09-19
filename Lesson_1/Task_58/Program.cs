/*  Задача 58. Задайте две матрицы. 
    Напишите программу, которая будет находить произведение двух матриц.
    
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[2, 2];

    matrixResult[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
    matrixResult[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
    matrixResult[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
    matrixResult[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

    return matrixResult;
}

int[,] matrixFirst = Create2DArray(2, 2);
Print2DArray(matrixFirst);
Console.WriteLine();

int[,] matrixSecond = Create2DArray(2, 2);
Print2DArray(matrixSecond);
Console.WriteLine();

Print2DArray(MatrixMultiplication(matrixFirst, matrixSecond));

// Test
// -------------------------------------------------
// int[,] matr1 = { { 2, 4 }, { 3, 2 } };
// Print2DArray(matr1);
// Console.WriteLine();
// int[,] matr2 = { { 3, 4 }, { 3, 3 } };
// Print2DArray(matr2);
// Console.WriteLine();
// Print2DArray(MatrixMultiplication(matr1, matr2));
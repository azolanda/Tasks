/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.  */

int[] CreateArray(int len)
{
    int[] array = new int[len];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;

    if (length == 0)
    {
        Console.WriteLine("Массив пустой");
    }
    else
    {
        string result = "[";
        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
                result += $"{array[i]}]";
            }
            else
            {
                result += $"{array[i]}, ";
            }
        }
        Console.WriteLine($"Сгенерированный массив: {result}");
    }
}

int CountEven(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Введите натуральное число - размер массива: ");
int length = int.Parse(Console.ReadLine());

if (length < 1)
{
    Console.WriteLine("Введено число в неверном формате. Введите натуральное число");
}
else
{
    int[] myArray = CreateArray(length);
    int result = CountEven(myArray);

    PrintArray(myArray);
    Console.WriteLine($"Количество чётных чисел в сгенерированном массиве: {result}");
}

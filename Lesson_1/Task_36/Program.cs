/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.  */

int[] CreateArray(int len)
{
    int[] array = new int[len];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

int SumOdd(int[] arr)
{
    int mySum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        mySum += arr[i];
    }

    return mySum;
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
    int sum = SumOdd(myArray);

    PrintArray(myArray);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в сгенерированном массиве: {sum}");
}
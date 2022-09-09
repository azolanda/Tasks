/*  Задача 38: Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.  */

double GetRandomNumber(double minimum, double maximum)
{
    double random = new Random().NextDouble();
    return random * (maximum - minimum) + minimum;
}

double[] CreateArray(int len)
{
    double[] array = new double[len];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetRandomNumber(-100.00, 101.00);
    }

    return array;
}

void PrintArray(double[] array)
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
                result += $"{Math.Round(array[i], 2)}]";
            }
            else
            {
                result += $"{Math.Round(array[i], 2)}, ";
            }
        }
        Console.WriteLine($"Сгенерированный массив: {result}");
    }
}

double Min(double[] arr)
{
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }

    return min;
}

double Max(double[] arr)
{
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    return max;
}

Console.WriteLine("Введите натуральное число - размер массива: ");
int length = int.Parse(Console.ReadLine());

if (length < 1)
{
    Console.WriteLine("Введено число в неверном формате. Введите натуральное число");
}
else
{
    double[] myArray = CreateArray(length);
    double minimum = Min(myArray);
    double maximum = Max(myArray);
    double result = Math.Round(maximum - minimum, 2);

    PrintArray(myArray);
    Console.WriteLine($"Разница между максимальным ({Math.Round(maximum, 2)}) и минимальным ({Math.Round(minimum, 2)}) элементами в сгенерированном массиве: {result}");
}
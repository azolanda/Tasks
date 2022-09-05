/*  Задача 29: Напишите программу, которая задаёт массив из элементов 
    и выводит их на экран.  */

void PrintArray(string[] array)
{
    int length = array.Length;

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
    Console.WriteLine($"Массив из введенных чисел: {result}");
}

Console.WriteLine("Введите элементы массива через пробел: ");
string arrStr = Console.ReadLine();

string[] arr = arrStr.Split(' ');

PrintArray(arr);






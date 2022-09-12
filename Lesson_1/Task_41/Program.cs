/*  Задача 41: Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь. */

int NumCounter(string[] array, int index)
{
    if (index < 0)
    {
        return 0;
    }

    int result = 0;

    if (int.Parse(array[index]) > 0)
    {
        result = 1;
    }

    return result += NumCounter(array, index - 1);
}

Console.WriteLine("Введите набор целых чисел через запятую: ");
string arrStr = Console.ReadLine();

string[] arr = arrStr.Split(',');
int count = NumCounter(arr, arr.Length - 1);
Console.WriteLine(count);
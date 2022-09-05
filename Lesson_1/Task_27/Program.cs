/*  Задача 27: Напишите программу, которая принимает на вход число 
    и выдаёт сумму цифр в числе.  */

int Sum(string numStr)
{
    if (numStr[0] == '-')
    {
        numStr = numStr.Substring(1);
    }

    int numLength = numStr.Length;
    int num = int.Parse(numStr);
    int sum = 0;

    if (numLength == 0)
    {
        return sum;
    }

    if (numLength == 1)
    {
        return num;
    }

    for (int i = 0; i < numLength; i++)
    {
        int part = num % 10;
        num = num / 10;
        sum += part;
    }

    return sum;
}

Console.WriteLine("Введите число: ");
string numericStr = Console.ReadLine();

int resultSum = Sum(numericStr);

Console.WriteLine($"Сумма цифр в числе {numericStr} равна: {resultSum}");
/*  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
    на выходе показывает вторую цифру этого числа.  */

int? SecondNum(string str)
{
    int[] numArray = new int[3];

    if (str[0] == '-')
    {
        str = str.Substring(1);
    }

    if (str.Length < 3 || str.Length > 3)
    {
        Console.WriteLine("Необходимо ввести трехзначное число");
        return null;
    }
    else
    {
        for (int i = 0; i < 3; i++)
        {
            numArray[i] = int.Parse(str[i].ToString());
        }
        int secondNum = numArray[1];
        return secondNum;
    }
}

Console.WriteLine("Введите трехзначное число:");
string numStr = Console.ReadLine();
int? secondNumber = SecondNum(numStr);
Console.WriteLine(secondNumber);
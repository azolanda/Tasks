/*  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
    на выходе показывает вторую цифру этого числа.  */

void SecondNum(string str, int[] numArray)
{
    if (str[0] == '-')
    {
        str = str.Substring(1);
    }

    if (str.Length < 3 || str.Length > 3)
    {
        Console.WriteLine("Необходимо ввести трехзначное число");
    }
    else
    {
        for (int i = 0; i < 3; i++)
        {
            numArray[i] = int.Parse(str[i].ToString());
        }
        int secondNum = numArray[1];
        Console.WriteLine(secondNum);
    }
}

Console.WriteLine("Введите трехзначное число:");
string numStr = Console.ReadLine();
int[] numArr = new int[3];
SecondNum(numStr, numArr);
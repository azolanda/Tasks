/*  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
    сообщает, что третьей цифры нет.  */

int? ThirdNum(string str)
{
    int[] numArray = new int[3];

    if (str[0] == '-')
    {
        str = str.Substring(1);
    }

    if (str.Length < 3)
    {
        return null;
    }
    else
    {
        for (int i = 0; i < 3; i++)
        {
            numArray[i] = int.Parse(str[i].ToString());
        }
        int thirdNum = numArray[2];
        return thirdNum;
    }
}

Console.WriteLine("Введите трехзначное число:");
string numStr = Console.ReadLine();
var thirdNumber = ThirdNum(numStr);
if (thirdNumber == null)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра заданного числа: " + thirdNumber);
}

/*  Задача 19: Напишите программу, которая принимает на вход пятизначное число 
    и проверяет, является ли оно палиндромом.  */

int[]? ToArray(string str)
{
    int[] numArray = new int[5];
    
    if (str[0] == '-')
    {
        str = str.Substring(1);
    }

    if (str.Length < 5 ||  str.Length > 5)
    {
        return null;
    }
    else
    {
        for (int i = 0; i < 5; i++)
        {
            numArray[i] = int.Parse(str[i].ToString());
        }

        return numArray;
    }
}

bool IsPalindrom(int[] array) 
{
    bool palindrom = false;
    for (int j = 0; j < array.Length / 2; j++)
    {
        if(array[j] != array[array.Length - 1 - j])
        {
            return palindrom;
        }
    }
    palindrom = true;
    return palindrom;
}

Console.WriteLine("Введите пятизначное число:");
string numStr = Console.ReadLine();
var strArray = ToArray(numStr);

if (strArray == null)
{
    Console.WriteLine("Введено число неверного формата. Необходимо ввести пятизначное число");
}
else
{
    bool isPalindrom = IsPalindrom(strArray);
    
    if(isPalindrom == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
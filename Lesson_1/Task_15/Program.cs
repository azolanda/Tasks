/*  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
    и проверяет, является ли этот день выходным.  */

bool? CheckDay(int num)
{
    string[] week = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };

    if (num < 1 || num > 7)
    {
        return null;
    }
    else
    {
        if (week[num - 1] == "сб" || week[num - 1] == "вс")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = int.Parse(Console.ReadLine());

if (CheckDay(number) == true)
{
    Console.WriteLine("Да");
}
else if (CheckDay(number) == false)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Вы ввели неверное число. Введите число от 1 до 7");
}

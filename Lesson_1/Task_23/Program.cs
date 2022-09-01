/*  Задача 23: Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.  */

    string? Cubs(double n) 
    {
        if(n < 1)
        {
            return null;
        }

        string strCubs = "";

        for(double i = 1; i <= n; i++)
        {
            double cub = Math.Pow(i, 3);
            strCubs+= cub + ", ";
        }

        return strCubs;
    }

    Console.WriteLine("Введите число, большее или равное 1: ");

    double num = double.Parse(Console.ReadLine());

    var cubsResult = Cubs(num);

    if(cubsResult == null)
    {
        Console.WriteLine("Вы ввели неверное чесло. Введите число, большее или равное 1.");
    }
    else
    {
        Console.WriteLine("Таблица кубов числа" + num + ": " + cubsResult);
    }

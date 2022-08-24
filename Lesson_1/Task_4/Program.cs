/*  Задача 4: Напишите программу, которая принимает на вход три числа 
    и выдаёт максимальное из этих чисел.  */

    Console.Write("Введите первое число: ");
    int firstNum = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int secondNum = int.Parse(Console.ReadLine());

    Console.Write("Введите третье число: ");
    int thirdNum = int.Parse(Console.ReadLine());

    int max = firstNum;

    if(firstNum == secondNum && secondNum == thirdNum) Console.WriteLine("Числа равны");
    else
    {
        if(max < secondNum) max = secondNum;
        if(max < thirdNum) max = thirdNum;
        Console.WriteLine("Максимальное число: " + max);
    }

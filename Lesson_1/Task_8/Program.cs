/*  Задача 8: Напишите программу, которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N.   */

    Console.WriteLine("Введите натуральное число: ");
    int num = int.Parse(Console.ReadLine());

    if(num < 1) Console.WriteLine("Введенное число не соответствует требованиям программы");
    else
    {
        int count = 1;
        while(count < num + 1)
        {
            if(count % 2 == 0)
            {
                Console.Write(count + " ");
                count+= 2;
            }
            else count++;
        }
    }
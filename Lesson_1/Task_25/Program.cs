/*  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
    и возводит число A в натуральную степень B.  */

int? NumPow(int a, int b)
{
    int result = a;

    if (a == 0 || a == 1)
    {
        return result;
    }

    if (b > 0)
    {
        for (int i = 1; i < b; i++)
        {
            result *= a;
        }
    }
    else
    {
        return null;
    }

    return result;
}

Console.WriteLine("Ведите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите натуральное число B: ");
int numB = int.Parse(Console.ReadLine());

var numResult = NumPow(a: numA, b: numB);

if (numResult == null)
{
    Console.WriteLine("Число B введено в неверном формате. Необходимо ввести натуральное число B.");
}
else
{
    Console.WriteLine($"Число A в степени B равно: {numResult}");
}




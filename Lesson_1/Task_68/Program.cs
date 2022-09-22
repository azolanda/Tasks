/*  Задача 68. Напишите программу вычисления функции Аккермана 
    с помощью рекурсии. Даны два неотрицательных числа m и n.

    m = 2, n = 3 -> A(m,n) = 29
*/

int[] GetNums()
{
    int[] nums = new int[2];
    Console.WriteLine("Введите натуральное число M, большее нуля: ");
    nums[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N, большее нуля. Если M равно нулю, N должно быть больше нуля: ");
    nums[1] = int.Parse(Console.ReadLine());
    return nums;
}

int? AkkermanFunction(int? m, int? n)
{
    if ((n < 0 || m < 0) || (n == 0 && m == 0))
    {
        return null;
    }

    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }

    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int[] numbers = GetNums();
var result = AkkermanFunction(numbers[0], numbers[1]);

if (result == null)
{
    Console.WriteLine("Ошибка. Введены неверные числа. " +
                        "Числа M и N должны быть больше нуля и не могут одновременно равняться нулю.");
}
else
{
    Console.WriteLine($"Функция Аккермана для чисел {numbers[0]} и {numbers[1]} равна {result}");
}
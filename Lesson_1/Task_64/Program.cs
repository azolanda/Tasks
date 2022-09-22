/*  Задача 64. Задайте значения M и N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от M до N.

    M = 1; N = 5. -> "1, 2, 3, 4, 5"
    M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

int[] GetNums()
{
    int[] nums = new int[2];
    Console.WriteLine("Ведите натуральное число M: ");
    nums[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите натуральное число N, большее или равное M: ");
    nums[1] = int.Parse(Console.ReadLine());
    return nums;
}

void PrintRecursiveNums(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine("Ошибка. Число N должно быть больше числа M.");
    }
    else if (m == n)
    {
        Console.WriteLine($"{m}");
    }
    else
    {
        Console.Write($"{m}, ");
        PrintRecursiveNums(++m, n);
    }
}

int[] numbers = GetNums();
PrintRecursiveNums(numbers[0], numbers[1]);
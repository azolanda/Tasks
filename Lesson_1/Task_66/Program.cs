/*  Задача 66. Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
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

int RecursiveSum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + RecursiveSum(++m, n);
}

int[] numbers = GetNums();

if (numbers[0] > numbers[1])
{
    Console.WriteLine("Ошибка. Число N должно быть больше числа M.");
}
else
{
    int resultSum = RecursiveSum(numbers[0], numbers[1]);
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {numbers[0]} до {numbers[1]} равна {resultSum}");
}
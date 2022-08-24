/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int min, max;
min = max = numberA;

if (numberA != numberB)
{
    if (min > numberB) min = numberB;
    else max = numberB;

    Console.WriteLine("Большее число: " + max);
    Console.WriteLine("Меньшее число: " + min);
}
else Console.WriteLine("Числа равны");

// See https://aka.ms/new-console-template for more information

// Пользователь вводит два числа. Определить насколько большее из них больше второго.

using System;

Console.Write("write value A: ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("write value B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

// int[] array = { valueA, valueB };
// int maxValue = array.Max();

// Console.WriteLine($"Max value = {maxValue}");
// Console.WriteLine($"Difference is: {maxValue - array.Min()}");
if (valueA >= valueB)
{
    Console.WriteLine($"Max value = {valueA}");
    Console.WriteLine($"Difference is: {valueA - valueB}");
}

else if (valueA <= valueB)
{
    Console.WriteLine($"Max value = {valueB}");
    Console.WriteLine($"Difference is: {valueB - valueA}");
}

else
{
    Console.WriteLine("Error");
}
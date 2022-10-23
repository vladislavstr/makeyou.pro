// See https://aka.ms/new-console-template for more information

// Пользователь вводит 3 числа. Выведите их в консоль в порядке возрастания.

using System;

Console.Write("write value A: ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("write value B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

Console.Write("write value С: ");
int valueC = Convert.ToInt32(Console.ReadLine());


// List<int> list = new List<int> { valueA, valueB, valueC};


// list.Sort();
// Console.WriteLine(string.Join(",", list));


if ((valueA <= valueB) && (valueB <= valueC))
{
    Console.Write($"ABC: {valueA} {valueB} {valueC}");
}

else if((valueA <= valueC) && (valueC <= valueB))
{
    Console.Write($"ACB: {valueA} {valueC} {valueB}");
}

else if ((valueB <= valueA) && (valueA <= valueC))
{
    Console.Write($"BAC: {valueB} {valueA} {valueC}");
}

else if ((valueB <= valueC) && (valueC <= valueA))
{
    Console.Write($"BCA: {valueB} {valueC} {valueA}");
}

else if ((valueC <= valueB) && (valueB <= valueA))
{
    Console.Write($"CBA: {valueC} {valueB} {valueA}");
}

else if ((valueC <= valueA) && (valueA <= valueB))
{
    Console.Write($"CAB: {valueC} {valueA} {valueB}");
}

else
{
    Console.Write("Error");
}
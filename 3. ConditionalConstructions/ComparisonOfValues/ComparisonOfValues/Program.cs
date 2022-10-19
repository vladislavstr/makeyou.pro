// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.

Console.Write("A: ");
int valueA = Convert.ToInt32(Console.ReadLine());


Console.Write("B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

int valueC = 0;

if (valueA > valueB)
{
    Console.Write("A > B ---> ");
    Console.Write($"A + B: {valueA + valueB}");
}

if (valueA == valueB)
{
    Console.Write("A = B ---> ");
    Console.Write($"A * B: {valueA * valueB}");
}

if (valueA < valueB)
{
    Console.Write("A < B ---> ");
    Console.Write($"A - B: {valueA - valueB}");
}
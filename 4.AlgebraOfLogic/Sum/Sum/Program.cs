// See https://aka.ms/new-console-template for more information

// Пользователь вводит 3 числа. Проверьте, что сумма любых двух чисел больше третьего.

Console.Write("write value A: ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("write value B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

Console.Write("write value С: ");
int valueC = Convert.ToInt32(Console.ReadLine());

if ((valueA + valueB) > valueC )
{
    Console.WriteLine("(A + B) > C ");
}

if ((valueC + valueB) > valueA)
{
    Console.WriteLine("(C + B) > A ");
}

if ((valueA + valueC) > valueB)
{
    Console.WriteLine("(A + C) > B ");
}
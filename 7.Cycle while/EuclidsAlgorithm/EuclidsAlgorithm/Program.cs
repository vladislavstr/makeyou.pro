// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

int a, n, div;

Console.Write("write value a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("write value b: ");
n = Convert.ToInt32(Console.ReadLine());

while (a != n)
{
    if (a > n)
    {
        a = a - n;
    }
    else
    {
        n = n - a;
    }
}

div = n;
Console.WriteLine($"div: {div}");
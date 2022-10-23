// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

//Console.Write("write value a: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("write value b: ");
//int b = Convert.ToInt32(Console.ReadLine());

//int divisor, bg, lt = 0;

//if (a > b)
//{
//    bg = a;
//    lt = b;
//    divisor = bg % lt;

//    while (a % divisor != 0 && b % divisor != 0)
//    {
//        bg = lt;
//        lt = divisor;
//        divisor = bg / lt;
//    }

//    Console.WriteLine(divisor);
//}

//else if (a < b)
//{
//    bg = b;
//    lt = a;
//    divisor = a % b;

//    while (a % divisor != 0 && b % divisor != 0)
//    {
//        bg = lt;
//        lt = divisor;
//        divisor = bg / lt;
//    }

//    Console.WriteLine(divisor);
//}
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
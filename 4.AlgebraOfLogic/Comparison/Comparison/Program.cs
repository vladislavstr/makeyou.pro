// See https://aka.ms/new-console-template for more information

// Пользователь вводит 3 числа. Выведите их в консоль в порядке убывания за 3 условия.

Console.WriteLine("Hello, World!");

Console.Write("write value A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("write value B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("write value С: ");
int c = Convert.ToInt32(Console.ReadLine());

int x = 0;

if (a < b)
{
    x = b;
    b = a;
    a = x;
}
if (a < c)
{
    x = c;
    c = a;
    a = x;
}
if (b < c)
{
    x = c;
    c = b;
    b = x;
}

Console.WriteLine($"{a},{b},{c}");
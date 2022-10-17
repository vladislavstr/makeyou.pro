// See https://aka.ms/new-console-template for more information

// Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.

Console.WriteLine($"A*X+B=C");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("C: ");
int c = Convert.ToInt32(Console.ReadLine());

double x = (c - b)/a;

Console.WriteLine($"X = {x}");
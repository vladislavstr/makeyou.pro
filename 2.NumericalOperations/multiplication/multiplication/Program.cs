// See https://aka.ms/new-console-template for more information

// Пользователь вводит 2 числа (A и B). Выведите в консоль результат умножения A на B и остаток от деления B на A.

Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"A * B= {a*b}");
Console.WriteLine($"A % B= {a % b}");
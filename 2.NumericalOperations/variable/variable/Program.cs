// See https://aka.ms/new-console-template for more information

// 2) Пользователь вводит 2 числа (A и B). Поменяйте содержимое переменных A и B местами.

Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());


int c = b;
b = a;
a = c;

Console.WriteLine($"After replacing: A = {a}, B = {b}");
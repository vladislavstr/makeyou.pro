// See https://aka.ms/new-console-template for more information

// Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX^2+BX+C=0.

Console.WriteLine("AX^2+BX+C=0");

Console.Write("write value A: ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("write value B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

Console.Write("write value С: ");
int valueC = Convert.ToInt32(Console.ReadLine());

double discriminant = Math.Pow(valueB, 2) - (4 * valueA * valueC);

double x1 = 0;
double x2 = 0;

Console.WriteLine(discriminant);

if (discriminant < 0)
{
    Console.WriteLine("there are no valid roots!");
}

else if (discriminant == 0)
{
    x1 = -valueB / 2 / valueA;
    Console.WriteLine($"x1 = x2 = {x1}");
}

else if (discriminant > 0)
{
    x1 = (-valueB - Math.Sqrt(discriminant))/ 2 / valueA;
    x2 = (-valueB + Math.Sqrt(discriminant))/ 2 / valueA;

    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}

else
{
    Console.WriteLine("Error");
}
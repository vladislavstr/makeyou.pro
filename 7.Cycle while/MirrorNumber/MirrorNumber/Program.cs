// See https://aka.ms/new-console-template for more information

//Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

int val, tmp, count;

Console.Write("write value : ");
val = Convert.ToInt32(Console.ReadLine());

Console.Write($"Mirror of value {val}: ");
while (val != 0)
{
    tmp = val % 10;
    val = val / 10;
    Console.Write(tmp);
}

// See https://aka.ms/new-console-template for more information

//Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности).
//Определить модуль суммы каких чисел больше, положительных или отрицательных.

Console.Write("write value : ");

int value, neg, pos;
neg = pos = 0;

do
{
    value = Convert.ToInt32(Console.ReadLine());

    if (value < 0)
    {
        neg -= value;
    }

    else if (value > 0)
    {
        pos += value;
    }

}
while (value != 0);
Console.WriteLine("Finish");
Console.WriteLine($"Negative sum: {neg}");
Console.WriteLine($"Positive sum: {pos}");
// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся на 7.

Console.Write("write value : ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("write degree : ");
int valueB = Convert.ToInt32(Console.ReadLine());

int valueSum = 0;

for (int i = valueA; i < valueB; i++)

{
    if ((i % 7) == 0)
    {
        valueSum += i;
        Console.WriteLine(i);
    }
}

Console.WriteLine($"sum = {valueSum}");
// See https://aka.ms/new-console-template for more information

//Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());

for (int i = value; i <= 1000; i += value)
{
    Console.WriteLine(i);
}
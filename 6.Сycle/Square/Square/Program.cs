// See https://aka.ms/new-console-template for more information

//Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

using System;

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());

int squ = 1;

for (int i = 1; (i * squ) < value; i ++ )
{

    //Console.WriteLine($"value {value}");
    //Console.WriteLine($"squ {squ}");
    Console.WriteLine(i);

    squ++;
}
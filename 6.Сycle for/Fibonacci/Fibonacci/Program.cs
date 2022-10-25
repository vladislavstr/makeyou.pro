// See https://aka.ms/new-console-template for more information

//Пользователь вводит положительное число (N). Выведите N-ое число ряда Фибоначчи.
//В ряду Фибоначчи каждое следующее число является суммой двух предыдущих (1, 1, 2, 3, 5, 8, 13...).
//Первое и второе считаются равными 1.

using System;

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
int с = 0;

for (int i = 1; i <= value; i++)
{
    
    с = a;
    a = a + b;
    b = с;
    //Console.WriteLine($"a - {a}");
}

Console.WriteLine(a);
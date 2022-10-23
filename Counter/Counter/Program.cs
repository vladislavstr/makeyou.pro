// See https://aka.ms/new-console-template for more information

// Пользователь вводит положительное число (A). Вывести сумму всех цифр у чисел из диапазона от 0 до A.

Console.Write("write value : ");

int value, crnt,tmp;

value = Convert.ToInt32(Console.ReadLine());
crnt = tmp = 0;

while (crnt != value)
{
    crnt++;
    tmp += crnt;

}

Console.WriteLine($"sum in range: {tmp}");

// See https://aka.ms/new-console-template for more information

//Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

int tmp, value;
Console.Write("write value : ");
value = Convert.ToInt32(Console.ReadLine());

while (value != 0)
{

    tmp = value % 10;

    if(tmp % 2 != 0)
    {
        Console.WriteLine(tmp);
    }

    value = value / 10;
}

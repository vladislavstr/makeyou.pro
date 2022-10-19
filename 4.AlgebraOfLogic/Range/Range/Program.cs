// See https://aka.ms/new-console-template for more information

//Пользователь вводит число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50.

Console.Write("write value: ");

int value = Convert.ToInt32(Console.ReadLine());

if (((0<value) && (value<10)) || ((20 < value) && (value < 30)) || ((40 < value) && (value < 50)))
{
    Console.Write("value in range");
}

else
{
    Console.Write("return");
}

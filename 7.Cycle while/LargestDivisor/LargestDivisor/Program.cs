// See https://aka.ms/new-console-template for more information

// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());
int div = 0;


if (value == 0 || value == 1) 
{
    Console.WriteLine("Error");
}

else if (value < 0)
{
    div = value + 1;

    while (div < 1 && value % div != 0)
    {
        div++;
    }
}

else
{
    div = value - 1;
    while (div > 1 && value % div != 0)
    {
        div--;
    }
}

Console.WriteLine(div);
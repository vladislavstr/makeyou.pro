// See https://aka.ms/new-console-template for more information

//Пользователь вводит целое положительное число, которое является кубом числа N. Найдите число N методом половинного деления.

int val, tmp, cub;

Console.Write("write value : ");
val = Convert.ToInt32(Console.ReadLine());

cub = 0;

if (val >= 8) {

    while (cub != val)
    {
        tmp = val / 2;
        cub = tmp * tmp * tmp;

        if (cub > val)
        {
            tmp = tmp / 2;

        }

        else if (cub < val)
        {
            cub = cub / 2;
        }

     Console.WriteLine(cub);
    }
}
else
{
    Console.WriteLine("Error");
}
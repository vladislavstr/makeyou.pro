// See https://aka.ms/new-console-template for more information

// Пользователь вводит в консоль число. Определить четным или нечетным оно является.

Console.Write("write value: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value % 2 == 0)
{
    Console.WriteLine($"value {value} is even");
}

else
{
    Console.WriteLine($"value {value} is odd");
    Console.WriteLine("enter the value again");
}
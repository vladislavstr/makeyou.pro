// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write("write degree : ");
int degee = Convert.ToInt32(Console.ReadLine());

int valueDg = value;

for (int i = 1; i < degee; i++)
{
    valueDg *= value;
}

Console.WriteLine($"value {value} in degree {degee} = {valueDg}");
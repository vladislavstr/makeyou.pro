// See https://aka.ms/new-console-template for more information

//Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности).
//Найти самое большое число последовательности.

Console.Write("write value : ");
int value, tmp;
tmp = 0;
do
{
    value = Convert.ToInt32(Console.ReadLine());
    if (value > tmp)
    {
        tmp = value;
    }
}
while (value != 0);
Console.WriteLine("Finish");
Console.WriteLine($"Max value: {tmp}");

// See https://aka.ms/new-console-template for more information

//Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности).
//Найти количество чисел в последовательности, которые делятся на 3, 7 или 11.

Console.Write("write value : ");
int value, tmp;
tmp = 0;
do
{
    value = Convert.ToInt32(Console.ReadLine());
    if (value % 3 == 0 || value % 7 == 0 || value % 11 == 0)
    {
        tmp++;
    }
    //Console.WriteLine($"Count: {tmp}");
}
while (value != 0);
Console.WriteLine("Finish");
Console.WriteLine($"Count: {tmp-1}");
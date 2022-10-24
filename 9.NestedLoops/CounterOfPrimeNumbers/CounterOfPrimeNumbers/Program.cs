// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа (A и B).
//Вывести количество простых чисел (которые делятся только на 1 и самих себя) в диапазоне от A до B.


Console.Write("bergin: ");
int valueBg = Convert.ToInt32(Console.ReadLine());

Console.Write("end: ");
int valueEnd = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = valueBg; i <= valueEnd; i++)
{
    bool tmpFlag = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            tmpFlag = false;
            break;
        }
    }
    if (tmpFlag)
    {
        count++;
        //Console.WriteLine(i);
    }
}

Console.WriteLine(count);

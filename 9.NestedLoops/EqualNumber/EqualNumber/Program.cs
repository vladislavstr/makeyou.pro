// See https://aka.ms/new-console-template for more information

//Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
//Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”.

Console.Write("Value A: ");
int valueA = Convert.ToInt32(Console.ReadLine());

Console.Write("Value B: ");
int valueB = Convert.ToInt32(Console.ReadLine());


int numB, numA, count;  
numA = numB = count = 0;

while (valueA !=0)
{

    numA = valueA % 10;
    valueA /= 10;

    int tmpValB = valueB;

    while (tmpValB != 0)
    {

        numB = tmpValB % 10;
        tmpValB /= 10;

        if (numA == numB)
        {

            count++;
            
        }
    }
}
if (count > 0)
{
    Console.WriteLine($"Да, {count} знак/a");
}
else
{
    Console.WriteLine("НЕТ");
}
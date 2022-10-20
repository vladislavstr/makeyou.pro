// See https://aka.ms/new-console-template for more information

//Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

Console.Write("write value : ");
int value = Convert.ToInt32(Console.ReadLine());


if ((value < 100) && (value > 10))
{
    string valFirstStr = "nan";
    string valSecondStr = " ";

    if ((value < 20) && (value > 10))
    {
        switch (value)
        {
            case 11:
                valFirstStr = "Одиннадцать";
                break;

            case 12:
                valFirstStr = "Двенадцать";
                break;

            case 13:
                valFirstStr = "Тринадцать";
                break;

            case 14:
                valFirstStr = "Четырнадцать";
                break;

            case 15:
                valFirstStr = "Патнадцать";
                break;

            case 16:
                valFirstStr = "Шестнадцать";
                break;

            case 17:
                valFirstStr = "Семнадцать";
                break;

            case 18:
                valFirstStr = "Восемнадцать";
                break;

            case 19:
                valFirstStr = "Девятнадцать";
                break;
        }
        Console.WriteLine($"{valFirstStr} - {value}");
    }

    else if ((value < 100) && (value > 20))
    {
        int valBg = value / 10;
        int valSm = value % 10;

        //Console.WriteLine($"{valBg}");
        //Console.WriteLine($"{valSm}");

        switch (valBg)
        {
            case 2:
                valFirstStr = "Двадцать";
                break;

            case 3:
                valFirstStr = "Тридцать";
                break;

            case 4:
                valFirstStr = "Сорок";
                break;

            case 5:
                valFirstStr = "Патьдесят";
                break;

            case 6:
                valFirstStr = "Шестьдесят";
                break;

            case 7:
                valFirstStr = "Семьдесят";
                break;

            case 8:
                valFirstStr = "Восемьдесят";
                break;

            case 9:
                valFirstStr = "Девяносто";
                break;
        }

        switch (valSm)
        {

            case 1:
                valSecondStr = "oдин";
                break;

            case 2:
                valSecondStr = "два";
                break;

            case 3:
                valSecondStr = "три";
                break;

            case 4:
                valSecondStr = "четыре";
                break;

            case 5:
                valSecondStr = "пать";
                break;

            case 6:
                valSecondStr = "шесть";
                break;

            case 7:
                valSecondStr = "семь";
                break;

            case 8:
                valSecondStr = "восемь";
                break;

            case 9:
                valSecondStr = "девять";
                break;
        }
        Console.WriteLine($"{valFirstStr} {valSecondStr} - {value}");

    }
}

else
{
    Console.WriteLine("Error");
}
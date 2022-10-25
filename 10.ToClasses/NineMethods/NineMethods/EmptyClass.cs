using System;

namespace NineMethods
{
    public static class Math
    {
        //1) Метод получает на вход 3 числа(A, B и С). Верните решение(значение X) линейного уравнения стандартного вида, где A* X+B=C.
        public static Double SolvingEquation( int a, int b, int c)
        {
            return (c - b) / a;
        }


        //2) Метод получает на вход 2 числа(A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A* B, если A меньше B, подсчитать A-B.
        public static int ComparisonAndOperationsionsValues(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = a + b;
            }
            else if (a == b)
            {
                c = a * b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            return c;
        }


        //3) Метод получает на вход двузначное число.Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string ConvertValueInString(int value)
        {
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
                    return valFirstStr;
                }

                else if ((value < 100) && (value > 20))
                {
                    int valBg = value / 10;
                    int valSm = value % 10;

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
                    return valFirstStr + " " + valSecondStr;

                }
            }

        }


        //4) Метод получает на вход число.Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
        public static bool CheckRange(int value)
        {
            bool a;
            if (((0 < value) && (value < 10)) || ((20 < value) && (value < 30)) || ((40 < value) && (value < 50)))
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }


        //5) Метод получает на вход 2 числа(A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
        public static int SolvingLinearEquation(int a, int b)
        {
        }


        //6) Метод получает на вход положительное число(N). Верните N-ое число ряда Фибоначчи.
        public static int SolvingLinearEquation(int a)
        {
        }


        //7) Метод получает на вход число.Найти количество нечетных цифр этого числа.
        public static int SolvingLinearEquation(int a)
        {
        }


        //8) Метод получает на вход число.Найти число, которое является зеркальным
        public static int SolvingLinearEquation(int a)
        {
        }


        //9) Метод получает на вход 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
        public static bool SolvingLinearEquation(int a)
        {
        }
    }
}


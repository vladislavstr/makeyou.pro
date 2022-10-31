namespace NineMethods.Test;
using NineMethods;
using System;

public class MathOponTests
{
    //1) Метод получает на вход 3 числа (A, B и С). Верните решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
    // (c - b) / a
    [TestCase(1, 1, 2, 1)]
    [TestCase(-1, -1, -2, 1)]
    [TestCase(1, -1, 0, 1)]
    //[TestCase(0, 0, 0, 0)]

    public void SolvingEquation_1Test(int a, int b, int c, double expected)
    {
        double actual = MathOpon.SolvingEquation_1(a, b, c);

        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void SolvingEquation_1_WhenAIsZero_ShuldArgumtntExaption() //(int a, int b, int c, double expected)
    {
        int b = 1;
        int c = 2;
        int a = 0;

        Assert.Throws<ArgumentException>(() => MathOpon.SolvingEquation_1(a, b, c));
    }


    //2)
    [TestCase(2, 1, 3)]
    [TestCase(-2, -1, -1)]
    [TestCase(2, -1, 1)]
    [TestCase(0, 0, 0)]

    public void ComparisonAndOperationsionsValues_2Test(int a, int b, int expected)
    {
        int actual = MathOpon.ComparisonAndOperationsionsValues_2(a, b);

        Assert.AreEqual(expected, actual);
    }

    ////3) Метод получает на вход двузначное число.Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
    //public string ConvertValueInString_3(int value, int expected)
    //{


    //    Assert.AreEqual(expected, actual);
    //}


    //4) Метод получает на вход число.Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
    [TestCase(1, true)]
    [TestCase(-1, false)]
    [TestCase(0, false)]

    public void CheckRange_4Test(int value, bool expected)
    {
        bool actual = MathOpon.CheckRange_4(value);

        Assert.AreEqual(expected, actual);
    }


    //5) Метод получает на вход 2 числа(A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
    [TestCase(1, 8, 7)]
    [TestCase(-8, -1, -7)]
    [TestCase(-8, 8, 0)]
    [TestCase(0, 0, 0)]

    public void CountNumInRange_5Test(int a, int b, int expected)
    {
        int actual = MathOpon.CountNumInRange_5(a, b);

        Assert.AreEqual(expected, actual);
    }


    //6) Метод получает на вход положительное число(N). Верните N-ое число ряда Фибоначчи.
    [TestCase(4, 3)]
    [TestCase(10, 55)]
    
    public void FibonacciCounting_6Test(int value, int expected)
    {
        int actual = MathOpon.FibonacciCounting_6(value);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FibonacciCounting_6_WhenAIsZero_ShuldArgumtntExaption() //(int a, int b, int c, double expected)
    {
        int value = 0;

        Assert.Throws<ArgumentException>(() => MathOpon.FibonacciCounting_6(value));
    }

    //7) Метод получает на вход число.Найти количество нечетных цифр этого числа.

    [TestCase(123, 2)]
    [TestCase(-53, 2)]
    [TestCase(0, 0)]

    public void OddNumberCounter_7Test(int value, int expected)
    {
        int actual = MathOpon.OddNumberCounter_7(value);

        Assert.AreEqual(expected, actual);
    }


    ////8) Метод получает на вход число.Найти число, которое является зеркальным
    //public string MirrorNumberSearch_8(int value, int expected)
    //{


    //    Assert.AreEqual(expected, actual);
    //}


    //9) Метод получает на вход 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
    [TestCase(123, 456, false)]
    [TestCase(-425, 146, true)]


    public void SolvingLinearEquation_9Test(int valueA, int valueB, bool expected)
    {
        bool actual = MathOpon.SolvingLinearEquation_9(valueA, valueB);

        Assert.AreEqual(expected, actual);
    }

}

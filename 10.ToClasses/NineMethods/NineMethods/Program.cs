// See https://aka.ms/new-console-template for more information

using NineMethods;

Console.Write("Write value A: ");
int a = MathOpon.ReadFromConsole();

Console.Write("Write value B: ");
int b = MathOpon.ReadFromConsole();

Console.Write("Write value C: ");
int c = MathOpon.ReadFromConsole();

int resInt;
double resDb;
string resStr;
bool resBool;


//1) Метод получает на вход 3 числа (A, B и С). Верните решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
Console.Write("1)");

resDb = MathOpon.SolvingEquation_1(a, b, c);
MathOpon.WriteResultDouble(resDb);

Console.WriteLine("##################");


//2) Метод получает на вход 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.
Console.Write("2)");

resInt = MathOpon.ComparisonAndOperationsionsValues_2(a,b);
MathOpon.WriteResultInt(resInt);

Console.WriteLine("##################");


//3) Метод получает на вход двузначное число. Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
Console.Write("3)");

resStr = MathOpon.ConvertValueInString_3(c);
MathOpon.WriteResultStr(resStr);

Console.WriteLine("##################");


//4) Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
Console.Write("4)");

resBool = MathOpon.CheckRange_4(c);
MathOpon.WriteResultBool(resBool);

Console.WriteLine("##################");


//5) Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
Console.Write("5)");

resInt = MathOpon.CountNumInRange_5(a, b);
MathOpon.WriteResultInt(resInt);

Console.WriteLine("##################");


//6) Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.
Console.Write("6)");

resInt = MathOpon.FibonacciCounting_6(c);
MathOpon.WriteResultInt(resInt);

Console.WriteLine("##################");


//7) Метод получает на вход число. Найти количество нечетных цифр этого числа.
Console.Write("7)");

resInt = MathOpon.OddNumberCounter_7(c);
MathOpon.WriteResultInt(resInt);

Console.WriteLine("##################");


//8) Метод получает на вход число. Найти число, которое является зеркальным
Console.Write("8)");

resStr = MathOpon.MirrorNumberSearch_8(c);
MathOpon.WriteResultStr(resStr);

Console.WriteLine("##################");


//9) Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
Console.Write("9)");

resBool = MathOpon.SolvingLinearEquation_9(a, b);
MathOpon.WriteResultBool(resBool);

Console.WriteLine("##################");
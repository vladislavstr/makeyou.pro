using OperationsWithArrays;


Console.Write("Write array: ");
int[] array = ArrayDo.ReadFromConsole();

int resInt;
int[] resArray;


//1) Найти минимальный элемент массива.
Console.Write("1)");

resInt = ArrayDo.SearchMinValue_1(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//2) Найти максимальный элемент массива.
Console.Write("2)");

resInt = ArrayDo.SearchMaxValue_2(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//3) Найти индекс минимального элемента массива.
Console.Write("3)");

resInt = ArrayDo.SearchIdMin_3(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//4) Найти индекс максимального элемента массива.
Console.Write("4)");

resInt = ArrayDo.SearchIdMax_4(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//5) Посчитать сумму элементов массива с нечетными индексами.
Console.Write("5)");

resInt = ArrayDo.AddOddId_5(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//6) Сделать реверс массива (массив в обратном направлении).
Console.Write("6)");

resArray = ArrayDo.ReverseArray_6(array);
ArrayDo.WriteResultArr(resArray);

Console.WriteLine("##################");


//7) Посчитать количество нечетных элементов массива.
Console.Write("7)");

resInt = ArrayDo.AddOddVal_7(array);
ArrayDo.WriteResultInt(resInt);

Console.WriteLine("##################");


//8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
Console.Write("8)");

resArray = ArrayDo.ReflectOfArray_8(array);
ArrayDo.WriteResultArr(resArray);

Console.WriteLine("##################");
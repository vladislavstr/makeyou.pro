using System;
using Methods;

int[,] array = MultiArrayDo.Generate(4, 4, 0, 10);

MultiArrayDo.WriteArray(array);

int resInt,a,b;

//1) Найти минимальный элемент массива
Console.Write("1)");

resInt = MultiArrayDo.MinArray_1(array);
MultiArrayDo.WriteInt(resInt);

Console.WriteLine("##################");


//2) Найти максимальный элемент массива
Console.Write("2)");

resInt = MultiArrayDo.MaxArray_2(array);
MultiArrayDo.WriteInt(resInt);

Console.WriteLine("##################");


//3) Найти индекс минимального элемента массива
Console.Write("3)");

(a,b) = MultiArrayDo.MinIndexArray_3(array);
MultiArrayDo.WriteIntInt(a, b);

Console.WriteLine("##################");
//4) Найти индекс максимального элемента массива
Console.Write("4)");

(a, b) = MultiArrayDo.MaxIndexArray_4(array);
MultiArrayDo.WriteIntInt(a,b);

Console.WriteLine("##################");
//5) Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.
Console.Write("5)");

resInt = MultiArrayDo.CountArray_5(array);
MultiArrayDo.WriteInt(resInt);

Console.WriteLine("##################");

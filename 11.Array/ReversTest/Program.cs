// See https://aka.ms/new-console-template for more information


int[] array = new int[] { 2, 3, 4, 5 };

int len = array.Length-1;

Console.WriteLine(len);
Console.WriteLine(array[len-1]);

int[] arrayRevers = new int[len];

//for (int i = 0; i < len; i++)
//{
//    arrayRevers[i] = array[len - i];
//}

//Console.WriteLine(arrayRevers);
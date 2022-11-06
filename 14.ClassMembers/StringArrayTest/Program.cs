// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

string[] array = new string[] { "lkhl", "kjk", "knkj" };

string tmp = "";
for (int i = 0; i < array.Length; i++)
{
    tmp += array[i] + " ";

}
Console.WriteLine(tmp);
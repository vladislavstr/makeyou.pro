// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.Write("Len array: ");
int len = Convert.ToInt32(Console.ReadLine());

int value;

int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    Console.Write("Value: ");
    value = Convert.ToInt32(Console.ReadLine());

    array[i] = value;
}


for (int i = 0; i < len; i++)
{
    Console.Write($"Value: {array[i]}");
    
}
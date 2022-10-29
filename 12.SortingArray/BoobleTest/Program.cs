// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 800, 11, 50, 771, 649, 770, 240, 9 };

int temp = 0;
int len = array.Length;

for (int write = 0; write < len; write++)
{

    for (int sort = 0; sort < len - 1; sort++)
    {

        if (array[sort] > array[sort + 1])
        {

            temp = array[sort + 1];
            array[sort + 1] = array[sort];
            array[sort] = temp;

        }
    }
}

for (int i = 0; i < len; i++)
    Console.Write(array[i] + " ");

Console.ReadKey();
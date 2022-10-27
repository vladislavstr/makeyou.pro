// See https://aka.ms/new-console-template for more information


int[] array = new int[] { 2, 3, 4, 5 };

int max = array[0];

for(int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine(max);
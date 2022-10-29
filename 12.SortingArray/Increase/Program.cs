//// See https://aka.ms/new-console-template for more information
int[] gn_1 = Generate(10, 0, 10);
int[] gn_2 = Generate(10, 0, 10);

Write(gn_1);
gn_1 = SortBubblle(gn_1);
Write(gn_1);
Console.WriteLine("#########################");

Write(gn_2);
gn_2 = SortDirectSelection(gn_2);
Write(gn_2);
Console.WriteLine("#########################");


//1) Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert))

int[] SortBubblle(int[] array)
{
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
    return array;
}



//2) Отсортировать массив по убыванию одним из способов, (отличным способом) : пузырьком(Bubble), выбором(Select) или вставками(Insert))

//direct selection method
int[] SortDirectSelection(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len - 1; i++)
    {
        int minIndex = i;
        for (int j = i; j < len; j++)
        {
            if (array[minIndex] < array[j])
            {
                minIndex = j;
            }
            int tmp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = tmp;
        }
    }

    return array;
}



// Generate of array

int[] Generate(int lenArray, int begininngArray, int endArray)
{
    int[] array = new int[lenArray];

    Random random = new Random();

    for (int i = 0; i < lenArray; i++)
    {
        array[i] = random.Next(begininngArray, endArray + 1);
    }
    return array;
}


//Wrire array
void Write(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("");
}

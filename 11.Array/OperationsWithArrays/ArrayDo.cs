using System;
namespace OperationsWithArrays
{
    public static class ArrayDo
    {
        //Для ввода данных
        public static int[] ReadFromConsole()
        {

            Console.Write("Len array: ");

            int len = Convert.ToInt32(Console.ReadLine());
            int value;
            int[] array = new int[len];

            for (int i = 0;i< len; i++)
            {
                Console.Write($"Value {i}: ");
                value = Convert.ToInt32(Console.ReadLine());

                array[i] = value;
            }

            return array;

        }


        // Для вывода результатов
        public static void WriteResultInt(int res)
        {
            Console.WriteLine($"Result: {res}");
        }

        public static void WriteResultArr(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array);
        }


        //1) Найти минимальный элемент массива.
        public static int SearchMinValue_1(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }


        //2) Найти максимальный элемент массива.
        public static int SearchMaxValue_2(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }


        //3) Найти индекс минимального элемента массива.
        public static int SearchIdMin_3(int[] array)
        {
            int min = array[0];
            int minId = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minId = i;
                }
            }
            return minId;
        }


        //4) Найти индекс максимального элемента массива.
        public static int SearchIdMax_4(int[] array)
        {
            int max = array[0];
            int maxId = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxId = i;
                }
            }
            return maxId;
        }


        //5) Посчитать сумму элементов массива с нечетными индексами.
        public static int AddOddId_5(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }
            return sum;
        }


        //6) Сделать реверс массива(массив в обратном направлении).
        public static int[] ReverseArray_6(int[] array)
        {
            int lenArr = array.Length;
            int tmpLen = lenArr - 1;
            int[] arrayRevers = new int[lenArr];

            for (int i = 0; i < lenArr; i++)
            {
                arrayRevers[i] = array[tmpLen-i];
            }
            return arrayRevers;
        }


        //7) Посчитать количество нечетных элементов массива.
        public static int AddOddVal_7(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;//= array[i];
                }
                
            }
            return count;
        }


        //8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
        public static int[] ReflectOfArray_8(int[] array)
        {
            
            int len = array.Length;
            int mid = len / 2;

            for (int i = 0; i < mid; i++)
            {
                if (len % 2 == 0)
                {
                    int tmp = array[i];
                    array[i] = array[mid + i];
                    array[mid + i] = tmp;
                }
                else
                {
                    int tmp = array[i];
                    array[i] = array[mid + i + 1];
                    array[mid + i + 1] = tmp;
                }
            }

            return array;
        }


    }
}


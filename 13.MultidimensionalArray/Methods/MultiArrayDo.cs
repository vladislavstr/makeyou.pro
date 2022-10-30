using System;
namespace Methods
{
    public static class MultiArrayDo
    {


        /// Generate of array

        public static int[,] Generate(int heighArray,int lenArray, int beginArray, int endArray)
        {
            int[,] array = new int[heighArray, lenArray];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(beginArray, endArray + 1);
                }
            }
            return array;
        }



        //Wrire array
        public static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}, ");
                }
                Console.WriteLine("");
            }
        }

        public static void WriteInt(int res)
        {
            Console.WriteLine($"Result: {res}");
        }

        public static void WriteIntInt(int res1,int res2)
        {
            Console.WriteLine($"Result: {res1}, {res2}");
        }


        //1) Найти минимальный элемент массива
        public static int MinArray_1(int[,] array)
        {
            int val = array[0,0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (val > array[i, j])
                    {
                        val = array[i, j];
                    }
                }
            }
            return val;
        }


        //2) Найти максимальный элемент массива
        public static int MaxArray_2(int[,] array)
        {
            int val = array[0, 0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (val < array[i, j])
                    {
                        val = array[i, j];
                    }
                }
            }
            return val;
        }


        //3) Найти индекс минимального элемента массива
        public static (int,int) MinIndexArray_3(int[,] array)
        {
            int val = array[0,0];
            int valIdH = 0;
            int valIdL = 0;

            

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (val > array[i, j])
                    {
                        val = array[i, j];
                        valIdH = i;
                        valIdL = j;
                    }
                }
            }
            return (valIdH, valIdL);
        }


        //4) Найти индекс максимального элемента массива
        public static (int,int) MaxIndexArray_4(int[,] array)
        {
            int val = array[0, 0];
            int valIdH = 0;
            int valIdL = 0;



            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (val < array[i, j])
                    {
                        val = array[i, j];
                        valIdH = i;
                        valIdL = j;
                    }
                }
            }
            return (valIdH, valIdL);
        }


        //5) Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.
        public static int CountArray_5(int[,] array)
        {
            int valTmp = array[0, 0];
            int valTmpLeft = array[0, 0];
            int valTmpLow = array[0, 0];
            int count = 0;

            for (int i = 0; i < array.GetLength(0)-1; i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    valTmp = array[i, j];
                    valTmpLeft = array[i, j - 1];
                    valTmpLow = array[i + 1, j];

                    if (valTmp > valTmpLeft && valTmp > valTmpLow)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}


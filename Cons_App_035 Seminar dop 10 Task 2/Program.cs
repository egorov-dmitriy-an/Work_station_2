// Задача 2. Дана последовательность натуральных чисел.
// Определите значение второго по величине элемента в этой последовательности.
//    {1, 2, 3, 4, 5} >> 4
//    {7, 4, 2, 7, 6, 6, 8} >> 7

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 10 Задача 2 доп ============");
            Console.Write("Введите размер массива более 1: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            int mod = 0;
            int count = 0;
            int max = 0;
            int temp =-1;

            void Max(int[] arr)
            {
                if (mod < 2)
                {
                    max = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i != temp)
                        {
                            if (arr[i] > max)
                            {
                                max = arr[i];
                                count = i;
                            }
                        }
                    }
                    temp = count;
                    mod++;
                    Max(arr);
                }
                else
                {
                    Console.WriteLine("Значение второго по величине элемента равно = " + max);
                    return;
                }
            }
            Max(array);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
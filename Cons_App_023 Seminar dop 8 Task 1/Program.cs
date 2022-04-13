// Задача 1. Дан двумерный массив.
// Заменить в нём элементы первой строки элементами главной диагонали.
// А элементы последней строки, элементами побочной диагонали.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 8 Задача 1 доп =============");
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] startArray = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine("------------------------");
            void Fill(int[,] arr)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        startArray[i, j] = rand.Next(10, 100);
                    }
                }
            }
            void Print(int[,] arr)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine("");
                }
            }

            Fill(startArray);
            Print(startArray);
            Console.WriteLine("------------------------");
            int temp = startArray[0, n - 1];
            for (int i = 0; i < n; i++)
            {
                int j = i;
                startArray[0, j] = startArray[i, j];
                int k = n - 1 - i;
                startArray[n - 1, i] = startArray[k, i];
            }
            Console.WriteLine("Отсортированный массив: ");
            Console.WriteLine("------------------------");
            startArray[n - 1, n - 1] = temp;
            Print(startArray);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

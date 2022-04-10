// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 8 Задача 54 =================");
            Random rand = new Random();
            int m = rand.Next(1, 10);
            int n = rand.Next(1, 10);

            int[,] startArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    startArray[i, j] = rand.Next(10, 100);
                }
            }

            void PrintArray(int[,] curArray)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(startArray[i, j] + "  ");
                    }
                    Console.WriteLine("");
                }
            }

            void Sortirovka(int[,] curArray, int i)
            {
                int count = curArray.GetLength(1);
                for (int j = 1; j < count; j++)
                {
                    if (curArray[i, j] > curArray[i, j - 1])
                    {
                        int revers = curArray[i, j - 1];
                        curArray[i, j - 1] = curArray[i, j];
                        curArray[i, j] = revers;
                        Sortirovka(curArray, i);
                    }
                }
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine("-------------------");
            PrintArray(startArray);
            Console.WriteLine("-------------------");
            for (int i = 0; i < m; i++)
            {
                Sortirovka(startArray, i);
            }
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine("-------------------");
            PrintArray(startArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
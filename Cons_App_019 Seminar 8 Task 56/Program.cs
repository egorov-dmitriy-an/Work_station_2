// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 8 Задача 56 =================");
            Random rand = new Random();
            int m = rand.Next(2, 10);
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

            Console.WriteLine("Исходный массив:");
            Console.WriteLine("--------------------");
            PrintArray(startArray);

            int Summa(int[,] curArray, int i)
            {
                int summa = curArray[i, 0];
                {
                    for (int j = 1; j < curArray.GetLength(1); j++)
                    {
                        summa = summa + curArray[i, j];
                    }
                }
                return summa;
            }
            Console.WriteLine("--------------------");
            int minSumma = Summa(startArray, 0);
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Сумма элементов строки " + i + " равна " + Summa(startArray, i));
                if (Summa(startArray, i) < minSumma)
                {
                    minSumma = Summa(startArray, i);
                    count = i;
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("У строки № " + count + " сумма минимальна и равна " + minSumma );
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
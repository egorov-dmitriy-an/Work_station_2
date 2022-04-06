// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 7 Задача 52 =================");
            Console.Write("Введите количество строк массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            double[,] mnArray = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mnArray[i, j] = rand.Next(10);
                    Console.Write("   " + mnArray[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Cреднее арифметическое элементов в каждом столбце");
            void Average(double[,] curArray)
            {
                for (int k = 0; k < curArray.GetLength(1); k++)
                {
                    double sum = 0;
                    for (int l = 0; l < curArray.GetLength(0); l++)
                    {
                        sum = sum + curArray[l, k];
                    }
                    double aver = sum / curArray.GetLength(0);
                    Console.Write("|" + "{0:0.00}", aver);
                    Console.Write("|");
                }
                Console.WriteLine("");
            }
            Average(mnArray);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
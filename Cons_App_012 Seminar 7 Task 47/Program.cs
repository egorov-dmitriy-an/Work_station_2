// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2  -0,2
// 1  -3,3     8  -9,9
// 8   7,8  -7,1     9


using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 7 Задача 47 =================");
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
                    mnArray[i, j] = rand.NextDouble() + rand.Next(-9, 10);
                    Console.Write("   " + "{0: 0.0}", mnArray[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
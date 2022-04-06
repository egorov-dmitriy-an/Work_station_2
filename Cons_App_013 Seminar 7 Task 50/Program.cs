// Задача 50: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 3->3

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 7 Задача 50 =================");
            
            Random rand = new Random();
            int k = rand.Next(1, 10);
            int l = rand.Next(1, 10);
            int[,] randArray = new int[k, l];

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    randArray[i, j] = rand.Next(10);
                    Console.Write(randArray[i, j] + "  ");
                }
                Console.WriteLine("");
            }

            void PrintElement (int[,] arrayElement, int m, int n)
            {
                if(m < arrayElement.GetLength(0) && n < arrayElement.GetLength(1))
                {
                    Console.WriteLine("Элемент массива [" + m + ", " + n + "] равен: " + arrayElement[m,n]);
                }
                else Console.WriteLine("Такого элемента нет");
            }
            Console.Write("Введите номер строки массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер столбца массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintElement(randArray, m, n);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
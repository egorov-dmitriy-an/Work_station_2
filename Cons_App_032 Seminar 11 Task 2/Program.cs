// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10.
// Найдите количество элементов, значение которых больше 5, и их сумму.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 11 Задача 2 =================");
            Console.Write("Введите количство строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int[,] result = new int[m, n];
            int summa = 0;
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = rand.Next(1, 11);
                    Console.Write(result[i, j] + "\t");
                    if (result[i, j] > 5)
                    {
                        summa += result[i, j];
                        count++;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Сумма элементов больших 5 = " + summa);
            Console.WriteLine("Количество элементов больших 5 = " + count);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
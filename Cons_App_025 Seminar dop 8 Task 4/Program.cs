// Задача 4. Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.

// 1  6  7
// 2  5  8
// 3  4  9

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 8 Задача 4 доп =============");
            Console.Write("Введите количество строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] methodArray = new int[m, n];
            int[,] DownUp(int l, int count)
            {
                if (count <= n * m)
                {
                    for (int i = 0; i < m; i++)
                    {
                        count++;
                        methodArray[i, l] = count;
                    }
                    if (l + 1 < n)
                    {
                        l++;
                        for (int i = m - 1; i >= 0; i--)
                        {
                            count++;
                            methodArray[i, l] = count;
                        }
                    }
                    if (l + 1 < n) DownUp(l + 1, count);
                }
                return methodArray;
            }
            void Print(int[,] arr)
            {
                Console.WriteLine("------------------------");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++) Console.Write(arr[i, j] + "  ");
                    Console.WriteLine("");
                }
                Console.WriteLine("------------------------");
            }
            int[,] snakeArray = DownUp(0, 0);
            Print(snakeArray);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
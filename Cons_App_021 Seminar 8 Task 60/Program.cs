// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая построчно выведет элементы и их индексы.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 8 Задача 60 =================");

            Random rand = new Random();
            int m = rand.Next(2, 7);
            int n = rand.Next(2, 7);
            int k = rand.Next(1, (90 / m / n));
            Console.WriteLine("Размер исходного массива    [" + m + ", " + n + ", " + k + "]");
            int count = m * n * k;

            bool Poisk(List<int> listElemnt, int number)
            {
                int[] arrayElement = listElemnt.ToArray();
                for (int i = 0; i < arrayElement.Length; i++)
                {
                    if (number == arrayElement[i]) return false;
                }
                return true;
            }

            int tempNumber = 0;
            List<int> listResult = new List<int>();
            listResult.Add(rand.Next(10, 100));

            int[,,] threeArray = new int[m, n, k];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        bool mod = false;
                        while (mod == false)
                        {
                            tempNumber = rand.Next(10, 100);
                            mod = Poisk(listResult, tempNumber);
                        }
                        threeArray[i, j, l] = tempNumber;
                        Console.WriteLine("Элемент массива с индексами [" + i + ", " + j + ", " + l + "] = " + threeArray[i, j, l]);
                    }
                }
            }
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
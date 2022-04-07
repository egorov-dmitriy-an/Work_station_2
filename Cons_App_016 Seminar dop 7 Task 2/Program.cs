// Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
// Найдите в этом массиве и сохраните в одномерный массив все числа,
// сумма цифр которых больше их произведения. Выведите оба массива.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 7 Задача 2 доп =============");
            Console.WriteLine("Двумерный массив размером 3х4: ");
            int[,] array34 = new int[3, 4];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array34[i, j] = rand.Next(100, 10000);
                    Console.Write(array34[i, j] + "  ");
                }
                Console.WriteLine("");
            }

            bool SummaElement(int number)
            {
                int summa = 0;
                int multi = 1;
                int count = 0;
                while (number > 0)
                {
                    count = number % 10;
                    summa = summa + count;
                    multi = multi * count;
                    number = number / 10;
                }
                if (summa > multi) return true;
                else return false;
            }

            List<int> numbList = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (SummaElement(array34[i, j]) == true)
                    {
                        numbList.Add(array34[i, j]);
                    }
                }
            }
            int[] currArray = numbList.ToArray();
            Console.WriteLine("");
            Console.WriteLine("Числа, сумма цифр которых больше их произведения: ");
            int count = currArray.Length;
            for (int i = 0; i < count; i++) Console.Write(currArray[i] + "  ");
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
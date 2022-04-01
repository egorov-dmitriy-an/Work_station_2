// Задача 1*. Дан массив массивов, состоящих из натуральных чисел,
// размер которого 5. Для каждого элемента-массива определить сумму
// его элементов и вывести массив с наибольшей суммой. Если таких 
// массивов несколько, вывести массив с наименьшим индексом.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 5 Задача 1* доп =============");
            Console.WriteLine("");
            int Array_Sum(int[] numb_array_1) // метод суммы элементов массива
            {
                int sum_array = 0;
                for (int i2 = 0; i2 < numb_array_1.Length; i2++) sum_array = sum_array + numb_array_1[i2];
                return sum_array;
            }

            int[][] f_p_array = new int[5][];
            for (int j1 = 0; j1 < 5; j1++)
            {
                int leng2 = new Random().Next(1, 10);
                f_p_array[j1] = new int[leng2];
                for (int j2 = 0; j2 < leng2; j2++)
                {
                    f_p_array[j1][j2] = new Random().Next(-100, 100);
                    Console.Write(f_p_array[j1][j2] + ", ");
                }
                Console.WriteLine("");
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _Массив " + j1);
                Console.WriteLine("");
            }
            int summ_array = Array_Sum(f_p_array[0]);
            int mod = 0;
            for (int i2 = 1; i2 < 5; i2++)
            {
                if (Array_Sum(f_p_array[i2]) > summ_array)
                {
                    summ_array = Array_Sum(f_p_array[i2]);
                    mod = i2;
                }
            }
            Console.Write("Наибольшая сумма: " + summ_array);
            Console.WriteLine(" у массива с индексом: " + mod);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
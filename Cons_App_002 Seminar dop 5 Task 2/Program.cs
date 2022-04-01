// Задача 2. На вход подаются два числа случайной длины.
// Найдите произведение каждого разряда первого числа на каждый разряд второго.
// Ответ запишите в массив.
// 24, 132 -> {2, 6, 4, 4, 12, 8}

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 5 Задача 2 доп =============");

            int[] Array_Met(string number) // метод перевода числа в массив
            {
                int leng = number.Length;
                int[] numb_array = new int[leng];
                int numb_temp = Convert.ToInt32(number);
                for (int i = leng - 1; i >= 0; i--)
                {
                    numb_array[i] = numb_temp % 10;
                    numb_temp = numb_temp / 10;
                }
                return numb_array;
            }

            void Array_Umn(int[] numb_array_1, int[] numb_array_2) // метод перемножения элементнов двух массивов
            {
                int[] result_array = new int[numb_array_1.Length * numb_array_2.Length];
                int count = 0;
                for (int i2 = 0; i2 < numb_array_1.Length; i2++)
                {
                    for (int i3 = 0; i3 < numb_array_2.Length; i3++)
                    {
                        result_array[count] = numb_array_1[i2] * numb_array_2[i3];
                        Console.Write(result_array[count] + ", ");
                        count += 1;
                    }
                }
            }

            Console.Write("Введите первое число: ");
            string number_1 = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string number_2 = Console.ReadLine();
            Console.WriteLine("Произведение разряда первого числа на разряд второго");
            int[] arr1 = Array_Met(number_1);
            int[] arr2 = Array_Met(number_2);
            Array_Umn(arr1, arr2);
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
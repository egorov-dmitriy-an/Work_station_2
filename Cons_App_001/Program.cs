// Задача 1 Семинар 5 доп. Задан массив из случайных цифр на 15 элементов.
// На вход подаётся трёхзначное натуральное число. Напишите программу,
// которая определяет, есть в массиве последовательность из трёх элементов, 
// совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> не

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 5 Задача 34 ================");
            int[] array_numb = new int[15];
            for (int i = 0; i < 15; i++)
            {
                array_numb[i] = new Random().Next(1, 10);
                Console.Write(array_numb[i] + ", ");
            }
            Console.WriteLine("");
            Console.Write("Введите трехзначное число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            int mod = 0;
            for (int j = 0; j < array_numb.Length - 2; j++)
            {
                if (array_numb[j] == numb / 100 & array_numb[j + 1] == numb % 100 / 10 & array_numb[j + 2] == numb % 10)
                {
                    Console.WriteLine($"Есть последовательность из трёх элементов {array_numb[j]}, {array_numb[j+1]}, {array_numb[j+2]} совпадающая с введённым числом");
                    mod = 1;
                }
            }
            if (mod == 0) Console.WriteLine($"Нет последовательности из трёх элементов совпадающей с введённым числом");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
// Задача 3. Найдите все числа от 1 до 1000000
// сумма цифр которых в три раза меньше их произведений.
// Подсчитайте их количество.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 5 Задача 3 доп =============");

            int[] Array_Met(int number) // метод перевода числа в массив
            {
                string numb_temp = Convert.ToString(number);
                int[] numb_array = new int[numb_temp.Length];
                for (int i = numb_array.Length - 1; i >= 0; i--)
                {
                    numb_array[i] = number % 10;
                    number = number / 10;
                }
                return numb_array;
            }

            int Array_Sum(int[] numb_array_1) // метод суммы элементов массива
            {
                int sum_array = 0;
                for (int i2 = 0; i2 < numb_array_1.Length; i2++) sum_array = sum_array + numb_array_1[i2];
                return sum_array;
            }

            int Array_Umn(int[] numb_array_2) // метод умножения элементов массива
            {
                int umn_array = 1;
                for (int i3 = 0; i3 < numb_array_2.Length; i3++) umn_array = umn_array * numb_array_2[i3];
                return umn_array;
            }
            
            int sum = 0;
            for (int i3 = 1; i3 < 1000001; i3++)
            {
                int[] numb = Array_Met(i3);
                if (Array_Sum(numb) * 3 == Array_Umn(numb))
                {
                    Console.WriteLine($"Для числа {i3} сумма его цифр {Array_Sum(numb)} в три раза меньше их произведения {Array_Umn(numb)}");
                    sum += 1; 
                }
            }
            if (sum == 0 ) Console.WriteLine("Чисел, для которых сумма их цифр в три раза меньше их произведения, нет");
            else Console.WriteLine($"Количество чисел, для которых сумма их цифр в три раза меньше их произведения, равно: {sum}");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}




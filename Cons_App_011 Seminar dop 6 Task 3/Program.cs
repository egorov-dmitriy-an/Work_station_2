// Задача 3. Дано число N. Используя рекурсию, определите, что оно является степенью числа 3

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 6 Задача 3 доп =============");
            Console.Write("Введите число N: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double n = 1.0010992159842; // Определим степень с точностью 0,001 = 1/1000 => корень 1000 из 3 = 1.0010992159842
            double stepen = 0;
            double result = 0;

            double Step(double curnumber)
            {
                while (number >= 1.001)
                {
                    number = number / n;
                    stepen = stepen + 0.001;
                    result = stepen;
                    Step(number);
                }
                return result;
            }
            Console.WriteLine("Число N = 3 ^" + "{0: 0.000}", Step(number));
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
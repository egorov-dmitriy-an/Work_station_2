// Задача 43. Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 6 Задача 43 =================");
            Console.Write("Введите b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k1 = ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2 = ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            if (k1 == k2) Console.WriteLine("Прямые параллельны и не пересекаются");
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.Write("Прямые пересекаются в точке " + "{0: 0.00}", x);
                Console.WriteLine("; " + "{0: 0.00}", y);
            }
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
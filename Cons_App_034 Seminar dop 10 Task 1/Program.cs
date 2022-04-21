// Задача 1. Даны два числа a, b.
// Сложите их, используя только операции инкремента и декремента.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 10 Задача 1 доп ============");
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b; i++) a++;
            Console.WriteLine("Сумма a+b равна: " + a);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
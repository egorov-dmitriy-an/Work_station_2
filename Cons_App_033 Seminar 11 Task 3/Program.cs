// Задача 3. Напишите рекурсивный метод, который принимает
// номер года и определяет, является ли он високосным или нет.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 11 Задача 3 =================");
            void Year(int numb)
            {
                if (numb < 4)
                {
                    if (numb == 0) Console.WriteLine("Этот год високосный.");
                    else Console.WriteLine("Этот год невисокосный.");
                    return;
                }
                else 
                {
                    numb -= 4;
                    Year(numb);
                }
            }
            Console.Write("Введите номер года: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Year(number);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
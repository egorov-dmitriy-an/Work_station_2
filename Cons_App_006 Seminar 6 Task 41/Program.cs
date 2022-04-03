// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте,сколько чисел больше 0 ввёл пользователь.:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 6 Задача 41 =================");
            Console.Write("Введите количество проверяемых чисел: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                Console.Write("Введите число " + (i + 1) + " = ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0) count += 1;
            }
            Console.WriteLine("Количество введенных чисел > 0 равно: " + count);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
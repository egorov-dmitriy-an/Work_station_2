// Задача 1 доп Семинар 6. Написать перевод десятичного числа в двоичное, используя рекурсию

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 6 Задача 1 доп =============");
            Console.Write("Введите число в десятичной системе счисления: ");
            int dvoid = Convert.ToInt32(Console.ReadLine());
            string text = string.Empty;
            string Perevod(int number)
            {
                if (number >= 1)
                {
                    text = number % 2 + text;
                    Perevod(number/2);
                }
                return text;
            }
            if(dvoid==0) text = "0";
            else Perevod(dvoid);
            Console.Write("Это число в двоичной системе счисления: ");
            for (int i = 0; i < text.Length; i++) Console.Write(text[i]);
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
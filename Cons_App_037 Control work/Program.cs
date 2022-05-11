using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------------Контрольная работа--------------");

            // Предложим задать количество элементов массива и проверим введенные данные.
            Console.Write("Введите количество строк исходного массива: ");
            int length;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    if (length > 0) break;
                }
                Console.Write("Введите натуральное число: ");
            }

            // Инициализируем массив и предложим заполнить его строками.
            string[] textArray = new string[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Введите строку с индексом " + i + ": ");
                textArray[i] = Console.ReadLine();
            }
            Console.WriteLine("---------------------------------------------");

            // Выведем полученный массив.
            Console.Write("Исходный массив: ");
            Console.Write("[");
            for (int l = 0; l < length; l++)
            {
                Console.Write($"'{textArray[l]}'");
                if (l != length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");

            // Определим количество строк, длина которых менее или равна 3.
            int newLength = 0;
            for (int j = 0; j < length; j++)
            {
                if (textArray[j].Length <= 3) newLength++;
            }
            Console.WriteLine("---------------------------------------------");
            Console.Write("Новый массив: ");

            // Инициализируем новый массив.
            int count = 0; // Счетчик для индексов нового массива
            string[] newTextArray = new string[newLength];

            // Заполним массив строками, длина которых менее или равна 3 и выведем его.
            Console.Write("[");
            for (int k = 0; k < length; k++)
            {
                if (textArray[k].Length <= 3)
                {
                    newTextArray[count] = textArray[k];
                    Console.Write($"'{newTextArray[count]}'");
                    if (count != newLength - 1) Console.Write(", ");
                    count++;
                }
            }
            Console.WriteLine("]");
            Console.WriteLine("-------------------Конец---------------------");
            Console.WriteLine();
        }
    }
}
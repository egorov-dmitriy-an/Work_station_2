// Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
// Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 6 Задача 2 доп =============");
            string poslov = "без труда не выловишь и рыбку из пруда";
            int count = 0;
            string poslov_3 = string.Empty;
            string poslov_4 = string.Empty;

            string Poisk(string symbol)
            {
                string abc = "аоуиеёыюяэ";
                string poslov_2 = string.Empty;
                while (count < abc.Length)
                {
                    for (int i = 0; i < symbol.Length; i++) 
                    if (symbol[i] != abc[count]) poslov_2 = poslov_2 + symbol[i];
                    count += 1;
                    poslov_4 = poslov_2;
                    Poisk(poslov_2);
                }
                return poslov_4;
            }
            poslov_3 = Poisk(poslov);
            int glasn = poslov.Length - poslov_3.Length;
            Console.WriteLine("без труда не выловишь и рыбку из пруда");
            Console.WriteLine("Длина исходной пословицы: " + poslov.Length);
            for (int k = 0; k < poslov_3.Length; k++) Console.Write(poslov_3[k]);
            Console.WriteLine("");
            Console.WriteLine("Длина пословицы без гласных: " + poslov_3.Length);
            Console.WriteLine("Количество гласных букв равно: " + glasn);
             Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
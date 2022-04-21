// Задача 1. На вход подаются два числа n и m, такие, что n<m.
// Заполните массив случайными числами из промежутка [n, m].

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("");
          Console.WriteLine("=============== Семинар 11 Задача 1 =================");
          Console.Write("Введите начальное число: ");
          int n = Convert.ToInt32(Console.ReadLine());
          Console.Write("Введите конечное число больше " + n + ": ");
          int m = Convert.ToInt32(Console.ReadLine());
          Console.Write("Введите размер массива: ");
          int length = Convert.ToInt32(Console.ReadLine());

          Random rand = new Random();
          int[] result = new int[length];

          for (int i = 0; i < length; i++)
          {
          result[i] = rand.Next(n, m + 1);
          Console.Write(result[i] + ", ");
          }
          Console.WriteLine("");
          Console.WriteLine("=====================================================");
          Console.Write("Press any key to continue . . . ");
          Console.ReadKey(true);
        }
    }
}
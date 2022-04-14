// Задача 3. Найти минимальный по модулю элемент.
// Удалить столбец и диагонали, содержащие его.
// Заменим значения на 0.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 8 Задача 3 доп =============");
            Console.Write("Введите размер массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = m;

            int[,] startArray = new int[m, n];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            void Fill(int[,] arr)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++) arr[i, j] = rand.Next(1, 10);
                }
            }

            void Print(int[,] arr)
            {
                Console.WriteLine("------------------------");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++) Console.Write(arr[i, j] + "  ");
                    Console.WriteLine("");
                }
                Console.WriteLine("------------------------");
            }
            Fill(startArray);
            Print(startArray);

            int[] FindMin(int[,] arr)
            {
                int k = 0;
                int l = 0;
                int min = arr[0, 0];
                List<int> numberMN = new List<int>();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (Math.Abs(arr[i, j]) < Math.Abs(min))
                        {
                            min = arr[i, j];
                            k = i;
                            l = j;
                        }
                    }
                }
                numberMN.Add(k);
                numberMN.Add(l);
                numberMN.Add(min);
                Console.WriteLine("Минимальное значение " + min + " с индексами [" + k + ", " + l + "l");
                return numberMN.ToArray();
            }

            int[] resultArray = FindMin(startArray);
            int k = resultArray[0];
            int l = resultArray[1];
            int minNumber = resultArray[2];
            for (int i = 0; i < n; i++)
            {
                startArray[i, l] = 0;
            }
            Console.WriteLine("Заменили значения столбца " + l + " на 0");
            Print(startArray);

            int startMDown = 0;
            int startNDown = 0;

            if (k >= l)
            {
                startMDown = k - l;
                startNDown = 0;
            }
            else
            {
                startMDown = 0;
                startNDown = l - k;
            }

            while (startMDown < m & startNDown < n)
            {
                startArray[startMDown, startNDown] = 0;
                startMDown++;
                startNDown++;
            }
            Console.WriteLine("Заменили диагональ, параллельную главной, на 0");
            Print(startArray);

            k = resultArray[0];
            l = resultArray[1];

            int startMUp = 0;
            int startNUp = 0;

            if (k >= n - l)
            {
                startMUp = m;
                startNUp = k + l - n;
            }
            else
            {
                startMUp = k + l;
                startNUp = 0;
            }

            while (startMUp >= 0 & startNUp < n)
            {
                startArray[startMUp, startNUp] = 0;
                startMUp--;
                startNUp++;
            }
            Console.WriteLine("Заменили диагональ, параллельную побочной, на 0");
            Print(startArray);
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

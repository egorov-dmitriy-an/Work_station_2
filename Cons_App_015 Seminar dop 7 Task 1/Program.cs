// Задача 1 доп Семинар 7. Задача 1. Даны две матрицы,
// количество строк и столбцов которых может быть 3 или 4,
// заполнены числами от -9 до 9. Выполните умножение матриц.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 7 Задача 1 доп =============");
            Random rand = new Random();

            int[,] Matrix(int k, int l)
            {
                int[,] currMatrix = new int[k, l];
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        currMatrix[i, j] = rand.Next(0, 10);
                        Console.Write(currMatrix[i, j] + "     ");
                    }
                    Console.WriteLine("");
                }
                return currMatrix;
            }

            int m = rand.Next(3, 5);
            Console.WriteLine("m = " + m);
            int n = rand.Next(3, 5);
            Console.WriteLine("n = " + n);
            Console.WriteLine("  Матрица А:");
            int[,] matrixA = Matrix(m, n);
            Console.WriteLine("");
            Console.WriteLine("  Матрица В:");
            int[,] matrixB = Matrix(n, m);
            Console.WriteLine("");
            Console.WriteLine("Матрица C = AB:");
            int[,] matrixC = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    int count = 0;
                    matrixC[i, j] = 0;
                    while (count < n)
                    {
                        Console.WriteLine("   A (" + i + ", " + count + ") = " + matrixA[i, count]);
                        Console.WriteLine("   B (" + count + ", " + j + ") = " + matrixB[count, j]);
                        Console.WriteLine("  AxB = " + matrixA[i, count] * matrixB[count, j]);


                        matrixC[i, j] = matrixC[i, j] + matrixA[i, count] * matrixB[count, j];
                        count++;
                    }
                    Console.WriteLine("C(" + i + ", " + j + ") = " + matrixC[i, j] + "    ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
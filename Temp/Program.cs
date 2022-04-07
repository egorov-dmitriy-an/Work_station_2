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
                        currMatrix[i, j] = rand.Next(-9, 10);
                        Console.Write(currMatrix[i, j] + "     ");
                    }
                    Console.WriteLine("");
                }
                return currMatrix;
            }
            int Multiplication(int k, int l, int[,] matA, int[,] matB)
            {
                int sum = 0;
                int n = matA.GetLength(1);
                int multi = 0;
                for (int count = 0; count < n; count++)
                {
                    multi = matA[k, count] * matB[count, l];
                    sum = sum + multi;
                }
                return sum;
            }

            int m = rand.Next(3, 5);
            int n = rand.Next(3, 5);
            Console.WriteLine("Матрица А[" + m + ", " + n + "]");
            Console.WriteLine("--------------------");
            int[,] matrixA = Matrix(m, n);
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            int k = rand.Next(3, 5);
            int l = rand.Next(3, 5);
            Console.WriteLine("Матрица B[" + k + ", " + l + "]");
            Console.WriteLine("--------------------");
            int[,] matrixB = Matrix(k, l);
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            if (n != k)
            {
                Console.WriteLine("Операция матричного умножения C = AB не определена.");
                Console.WriteLine("Число столбцов матрицы A не совпадает с числом строк матрицы B.");
            }
            else
            {
                Console.WriteLine("Матрица C = AB[" + m + ", " + l + "]");
                Console.WriteLine("--------------------");
                int[,] matrixC = new int[m, l];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        matrixC[i, j] = Multiplication(i, j, matrixA, matrixB);
                        Console.Write(matrixC[i, j] + "   ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("=============== Семинар 8 Задача 58 =================");
            Random rand = new Random();

            int[,] Matrix(int k, int l)
            {
                int[,] currMatrix = new int[k, l];
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        currMatrix[i, j] = rand.Next(10, 100);
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
            Console.Write("Введите количество строк матрицы А: " );
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы А: " );
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Матрица А[" + m + ", " + n + "]");
            Console.WriteLine("--------------------");
            int[,] matrixA = Matrix(m, n);
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            Console.Write("Введите количество столбцов матрицы В: " );
            int l = Convert.ToInt32(Console.ReadLine());
            int k = n;
            Console.WriteLine("Количество строк матрицы В совпадает с количеством столбцов матрицы А: " + k);
            Console.WriteLine("Матрица B[" + k + ", " + l + "]");
            Console.WriteLine("--------------------");
            int[,] matrixB = Matrix(k, l);
            Console.WriteLine("--------------------");
            Console.WriteLine("");
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
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

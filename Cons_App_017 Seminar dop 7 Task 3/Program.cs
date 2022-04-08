// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями
// и единицами. Игрок может ходить только по полям, заполненным единицами.
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
// (эти поля требуется принудительно задать равными единице).

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array01 = new int[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array01[i, j] = rand.Next(0, 2);
                    }
                }

            array01[0, 0] = 1;
            array01[4, 4] = 1;

            void Print(int[,] arr)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(arr[i, j] + "  ");
                    }
                    Console.WriteLine("");
                }
            }

            Print(array01);

            bool Left(int i, int j, int[,] curArray)
            {
                if (j - 1 < 0) return false;
                if (curArray[i, j - 1] == 1) return true;
                else return false;
            }
            bool Right(int i, int j, int[,] curArray)
            {
                if (j + 1 > 4) return false;
                if (curArray[i, j + 1] == 1) return true;
                else return false;
            }
            bool Up(int i, int j, int[,] curArray)
            {
                if (i - 1 < 0) return false;
                if (curArray[i - 1, j] == 1) return true;
                else return false;
            }
            bool Down(int i, int j, int[,] curArray)
            {
                if (i + 1 > 4) return false;
                if (curArray[i + 1, j] == 1) return true;
                else return false;
            }

            int mod = 0;
            string direction = "down";
            List<int> listStroka = new List<int>();
            List<int> listStolb = new List<int>();


            string WayHome(int k, int l, int[,] methodArray)
            {
                bool GoToRight()
                {
                    if (Right(k, l, methodArray) == true)
                    {
                        l = l + 1;
                        if (k == 4 & l == 4) mod = 4;
                        if (k == 0 & l == 0) mod++;
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "right";
                        return true;
                    }
                    else return false;
                }
                bool GoToDown()
                {
                    if (Down(k, l, methodArray) == true)
                    {
                        k = k + 1;
                        if (k == 4 & l == 4) mod = 4;
                        if (k == 0 & l == 0) mod++;
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "down";
                        return true;
                    }
                    else return false;
                }
                bool GoToLeft()
                {
                    if (Left(k, l, methodArray) == true)
                    {
                        l = l - 1;
                        if (k == 4 & l == 4) mod = 4;
                        if (k == 0 & l == 0) mod++;
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "left";
                        return true;
                    }
                    else return false;
                }
                bool GoToUp()
                {
                    if (Up(k, l, methodArray) == true)
                    {
                        k = k - 1;
                        if (k == 4 & l == 4) mod = 4;
                        if (k == 0 & l == 0) mod++;
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "up";
                        return true;
                    }
                    else return false;
                }

                while (mod < 2)
                {
                    if (direction == "left")
                    {
                        GoToDown();
                        if (GoToDown() == false)
                        {
                            GoToLeft();
                            if (GoToLeft() == false)
                            {
                                GoToUp();
                                if (GoToUp() == false) GoToRight();
                            }
                        }
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "up")
                    {
                        GoToLeft();
                        if (GoToLeft() == false)
                        {
                            GoToUp();
                            if (GoToUp() == false)
                            {
                                GoToRight();
                                if (GoToRight() == false) GoToDown();
                            }
                        }
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "right")
                    {
                        GoToUp();
                        if (GoToUp() == false)
                        {
                            GoToRight();
                            if (GoToRight() == false)
                            {
                                GoToDown();
                                if (GoToDown() == false) GoToLeft();
                            }
                        }
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "down")
                    {
                        GoToRight();
                        if (GoToRight() == false)
                        {
                            GoToDown();
                            if (GoToDown() == false)
                            {
                                GoToLeft();
                                if (GoToLeft() == false) GoToUp();
                            }
                        }
                        WayHome(k, l, methodArray);
                    }
                    else mod = 3;
                    WayHome(k, l, methodArray);
                }
                string result = string.Empty;
                if (mod == 2) result = "Из [0, 0] не дойти по единицам до [4, 4]";
                if (mod == 3) result = "Из [0, 0] нет ни одного хода";
                if (mod == 4) result = "Из [0, 0] в [4, 4] можно дойти по единицам)";
                return result;
            }
            int m = 0;
            int n = 0;
            string finish =WayHome(m, n, array01);
            int[] xArray = listStroka.ToArray();
            int[] yArray = listStolb.ToArray();
            Console.Clear();
            for (int i = 0; i < xArray.Length; i++)
            {
                array01[listStroka[i], listStolb[i]] =  5;
                Console.Clear();
                Print(array01);
                Thread.Sleep(500);
            }
            Console.WriteLine(finish);
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
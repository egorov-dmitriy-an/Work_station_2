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
            Console.Clear();
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
                
                void GoToRight()
                {
                        l = l + 1;
                        if (k == 4 & l == 4) mod = 4;
                        Console.WriteLine("Идем вправо: (" + k + ", " + l +")");
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "right";
                        Thread.Sleep(500);
                }
                void GoToDown()
                {
                        k = k + 1;
                        if (k == 4 & l == 4) mod = 4;
                        Console.WriteLine("Идем вниз:   (" + k + ", " + l +")");
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "down";
                        Thread.Sleep(500);
                }
                void GoToLeft()
                {
                        l = l - 1;
                        if (k == 0 & l == 0) mod++;
                        Console.WriteLine("Идем влево:  (" + k + ", " + l +")");
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "left";
                        Thread.Sleep(500);
                }
                void GoToUp()
                {
                        k = k - 1;
                        if (k == 0 & l == 0) mod++;
                        Console.WriteLine("Идем вверх:  (" + k + ", " + l +")");
                        listStroka.Add(k);
                        listStolb.Add(l);
                        direction = "up";
                        Thread.Sleep(500);
                }

                while (mod < 2)
                {
                    if(methodArray[1, 0] == 0 & methodArray[0,1] == 0)
                    {
                        mod =3;
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "left")
                    {
                        if (Down(k, l, methodArray) == true) GoToDown();
                        else if (Left(k, l, methodArray) == true) GoToLeft();
                        else if (Up (k, l, methodArray) == true ) GoToUp();
                        else GoToRight();
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "up")
                    {
                        if (Left(k, l, methodArray) == true) GoToLeft();
                        else if (Up(k, l, methodArray) == true) GoToUp();
                        else if (Right (k, l, methodArray) == true ) GoToRight();
                        else GoToDown();
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "right")
                    {
                        if (Up(k, l, methodArray) == true) GoToUp();
                        else if (Right(k, l, methodArray) == true) GoToRight();
                        else if (Down (k, l, methodArray) == true ) GoToDown();
                        else GoToLeft();
                        WayHome(k, l, methodArray);
                    }
                    else if (direction == "down")
                    {
                        if (Right(k, l, methodArray) == true) GoToRight();
                        else if (Down(k, l, methodArray) == true) GoToDown();
                        else if (Left (k, l, methodArray) == true ) GoToLeft();
                        else GoToUp();
                        WayHome(k, l, methodArray);
                    }
                }
                string result = string.Empty;
                if (mod == 2) result = "Дважды вернулись в точку [0, 0], поэтому не дойти по единицам до [4, 4]";
                if (mod == 3) result = "Из [0, 0] нет вообще ни одного хода по единицам";
                if (mod == 4) result = "Из [0, 0] в [4, 4] можно дойти по единицам :)";
                return result;
            }
            int m = 0;
            int n = 0;
            string finish = WayHome(m, n, array01);
            int[] xArray = listStroka.ToArray();
            int[] yArray = listStolb.ToArray();
            Console.Write("Путь обозначим двойками");
            Thread.Sleep(5000);
            Console.Clear();
            if (xArray.Length == 0) 
            {
                Print(array01);
            }
            else
            {
                for (int i = 1; i < xArray.Length; i++)
                {
                    array01[listStroka[i-1], listStolb[i-1]] = 2;
                    Console.Clear();
                    array01[0, 0] = 2;
                    Print(array01);
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine(finish);
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
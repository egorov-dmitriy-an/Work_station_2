// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями
// и единицами. Игрок может ходить только по полям, заполненным единицами.
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
// (эти поля требуется принудительно задать равными единице).

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

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array01[i, j] + "  ");
    }
    Console.WriteLine("");
}

int mod = 0;
string direction = "down";

string WayHome(int k, int l, int[,] methodArray)
{
    bool GoToRight()
    {
        if (l + 1 > 4) return false;
        else if (methodArray[k, l + 1] == 1)
        {
            Console.WriteLine("mod на входе = " + mod + "   " + direction);
            Console.WriteLine("Мы на k = " + k + " l = " + l);
            l = l + 1;
            Console.WriteLine("Идем вправо на k = " + k + " l = " + l);
            if (k == 4 & l == 4) mod = 4;
            if (k == 0 & l == 0) mod++;
            Console.WriteLine("mod на выходе = " + mod);
            direction = "right";
            Console.WriteLine("");
            Thread.Sleep(1000);
            return true;
        }
        else return false;
    }

    bool GoToDown()
    {
        if (k + 1 > 4) return false;
        else if (methodArray[k + 1, l] == 1) 
        {
            Console.WriteLine("mod на входе = " + mod + "   " + direction);
            Console.WriteLine("Мы на k = " + k + " l = " + l);
            k = k + 1;
            if (k == 4 & l == 4) mod = 4;
            if (k == 0 & l == 0) mod++;
            Console.WriteLine("mod на выходе = " + mod);
            direction = "down";
            Console.WriteLine("Идем вниз k = " + k + " l = " + l);
            Console.WriteLine("");
            Thread.Sleep(1000);
            return true;
        }
        else return false;
    }
    
    bool GoToLeft()
    {
        if (l - 1 < 0) return false;
        else if (methodArray[k, l - 1] == 1) 
        {
            Console.WriteLine("mod на входе = " + mod + "   " + direction);
            Console.WriteLine("Мы на k = " + k + " l = " + l);
            l = l - 1;
            Console.WriteLine("Идем влево на k = " + k + " l = " + l);
            if (k == 4 & l == 4) mod = 4;
            if (k == 0 & l == 0) mod++;
            Console.WriteLine("mod на выходе = " + mod);
            direction = "left";
            Console.WriteLine("");
            Thread.Sleep(1000);
            return true;
        }
        else return false;
    }

    bool GoToUp()
    {
        if (k - 1 < 0) return false;
        else if (methodArray[k - 1, l] == 1)
        {
            Console.WriteLine("mod на входе = " + mod + "   " + direction);
            Console.WriteLine("Мы на k = " + k + " l = " + l);
            k = k - 1;
            Console.WriteLine("Идем вверх на k = " + k + " l = " + l);
            if (k == 4 & l == 4) mod = 4;
            if (k == 0 & l == 0) mod++;
            Console.WriteLine("mod на выходе = " + mod);
            direction = "up";
            Console.WriteLine("");
            Thread.Sleep(1000);
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
                        if (GoToUp() == false)
                        {
                            GoToRight();
                        }
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
                        if (GoToRight() == false)
                        {
                            GoToDown();
                        }
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
                        if (GoToDown() == false)
                        {
                            GoToLeft();
                        }
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
                        if (GoToLeft() == false)
                        {
                            GoToUp();
                        }
                    }
                }
        WayHome(k, l, methodArray);
        }
        else mod = 3;
        WayHome(k, l, methodArray);
    }
    string result = string.Empty;
    if (mod == 2) result = "Из точки [0, 0] не дойти";
    if (mod == 3) result = "Из точки [0, 0] нет ни одного хода";
    if (mod == 4) result = "Из точки [0, 0] в точку [4, 4] путь есть)))";
    return result;
}
int m = 0;
int n = 0;
Console.WriteLine(WayHome(m, n, array01));
Console.WriteLine("");